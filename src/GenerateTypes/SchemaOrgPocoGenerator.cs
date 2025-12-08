using Deploy.LaunchPad.Util.Methods;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;

namespace Deploy.GenerateSchemaOrgPocos
{
    public record SchemaClassInfo(
        string Id,
        string Name,
        string Label,
        string? Comment,
        string? BaseClassId)
    {
        public virtual List<SchemaPropertyInfo> Properties { get; } = new();
    }

    public record SchemaPropertyInfo(
        string Id,
        string Name,
        string Label,
        string? Comment,
        List<string> DomainIds,
        List<string> RangeIds);

    public partial class SchemaOrgPocoGenerator
    {

        public required virtual string SchemaOrgJsonLdFilePath { get; init; } = "./schemaorg-all-https.jsonld";
        public required virtual string OutputRoot { get; init; } = "../../../../Deploy.Schema.Org/Types";
        public virtual string SchemaOrgNamespace { get; init; } = "Deploy.Schema.Org";

        [SetsRequiredMembers]
        public SchemaOrgPocoGenerator(string schemaOrgJsonLdFilePath, string outputRoot)
        {
            SchemaOrgJsonLdFilePath = schemaOrgJsonLdFilePath;
            OutputRoot = outputRoot;
        }

        [SetsRequiredMembers]
        public SchemaOrgPocoGenerator(string schemaOrgJsonLdFilePath, string outputRoot, string schemaOrgNamespace)
        {
            SchemaOrgJsonLdFilePath = schemaOrgJsonLdFilePath;
            OutputRoot = outputRoot;
            SchemaOrgNamespace = schemaOrgNamespace;
        }

        public virtual async Task<LaunchPadMethodResult<GenerateSchemaOrgPocosResultValue>> GenerateTypesFromSchemaLdAsync()
        {

            using var stream = File.OpenRead(SchemaOrgJsonLdFilePath);
            using var doc = JsonDocument.Parse(stream);

            var root = doc.RootElement;
            if (!root.TryGetProperty("@graph", out var graph) || graph.ValueKind != JsonValueKind.Array)
            {
                Console.WriteLine("Invalid JSON-LD: missing @graph array.");
            }

            // --- Step 1: Collect data type IDs (Text, Boolean, Date, etc.) ----------
            var dataTypeIds = new HashSet<string>(StringComparer.Ordinal);

            foreach (var node in graph.EnumerateArray())
            {
                if (HasType(node, "schema:DataType"))
                {
                    var id = GetString(node, "@id");
                    if (!string.IsNullOrWhiteSpace(id))
                        dataTypeIds.Add(id!);
                }
            }
            // Ensure schema:URL is always treated as a primitive datatype (string/Uri)
            dataTypeIds.Add("schema:URL");

            // --- Step 2: Collect Schema.org classes (non-DataType) -----------------
            var classesById = new Dictionary<string, SchemaClassInfo>(StringComparer.Ordinal);

            foreach (var node in graph.EnumerateArray())
            {
                if (!HasType(node, "rdfs:Class"))
                    continue;

                var id = GetString(node, "@id");
                if (string.IsNullOrWhiteSpace(id))
                    continue;

                if (dataTypeIds.Contains(id!))
                {
                    // We'll map these to primitives, not POCOs.
                    continue;
                }
                if (id == "schema:URL")
                    continue;

                var label = GetString(node, "rdfs:label") ?? ExtractLocalName(id!);
                var name = SanitizeIdentifier(ToPascalCase(label));
                var comment = GetString(node, "rdfs:comment");

                string? baseId = null;
                if (node.TryGetProperty("rdfs:subClassOf", out var subEl))
                {
                    if (subEl.ValueKind == JsonValueKind.Object)
                    {
                        baseId = GetString(subEl, "@id");
                    }
                    else if (subEl.ValueKind == JsonValueKind.Array)
                    {
                        // If multiple inheritance, just pick the first listed base.
                        foreach (var item in subEl.EnumerateArray())
                        {
                            var cid = GetString(item, "@id");
                            if (!string.IsNullOrWhiteSpace(cid))
                            {
                                baseId = cid;
                                break;
                            }
                        }
                    }
                }

                var info = new SchemaClassInfo(
                    Id: id!,
                    Name: name,
                    Label: label,
                    Comment: comment,
                    BaseClassId: baseId);

                classesById[id!] = info;
            }

            // --- Step 3: Collect properties ---------------------------------------
            var properties = new List<SchemaPropertyInfo>();

            foreach (var node in graph.EnumerateArray())
            {
                if (!HasType(node, "rdf:Property"))
                    continue;

                var id = GetString(node, "@id");
                if (string.IsNullOrWhiteSpace(id))
                    continue;

                var label = GetString(node, "rdfs:label") ?? ExtractLocalName(id!);
                var propName = SanitizeIdentifier(ToPascalCase(label));
                var comment = GetString(node, "rdfs:comment");

                var domains = GetIdList(node, "schema:domainIncludes");
                var ranges = GetIdList(node, "schema:rangeIncludes");

                if (domains.Count == 0)
                {
                    // Some properties may not have explicit domain; we can ignore or later attach globally.
                    continue;
                }

                var propInfo = new SchemaPropertyInfo(
                    Id: id!,
                    Name: propName,
                    Label: label,
                    Comment: comment,
                    DomainIds: domains,
                    RangeIds: ranges);

                properties.Add(propInfo);
            }

            // Attach properties to classes
            foreach (var prop in properties)
            {
                foreach (var domainId in prop.DomainIds)
                {
                    if (classesById.TryGetValue(domainId, out var cls))
                    {
                        cls.Properties.Add(prop);
                    }
                }
            }

            // --- Step 4: Generate each class file ---------------------------------
            foreach (var kvp in classesById.OrderBy(k => k.Value.Name))
            {
                var cls = kvp.Value;
                var code = GenerateClassCode(cls, classesById, dataTypeIds);
                var fileName = cls.Name + ".cs";
                var path = Path.Combine(OutputRoot, fileName);
                File.WriteAllText(path, code, Encoding.UTF8);
                Console.WriteLine($"Generated: {fileName}");
            }
            var resultValue = new GenerateSchemaOrgPocosResultValue
            {
                DestinationFolderPath = OutputRoot
            };
            var methodResult = new LaunchPadMethodResult<GenerateSchemaOrgPocosResultValue>(resultValue);
            return methodResult;
        }

        protected virtual string GenerateClassCode(
            SchemaClassInfo cls,
            IDictionary<string, SchemaClassInfo> classesById,
            ISet<string> dataTypeIds)
        {
            var sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Text.Json.Serialization;");
            sb.AppendLine();
            sb.AppendLine($"namespace {SchemaOrgNamespace}");
            sb.AppendLine("{");

            if (!string.IsNullOrWhiteSpace(cls.Comment))
            {
                sb.AppendLine("    /// <summary>");

                foreach (var line in SplitDocLines(cls.Comment!))
                    sb.AppendLine($"    /// {EscapeXmlDoc(line)}");

                sb.AppendLine("    /// </summary>");
            }
            sb.Append("    public partial class ").Append(cls.Name);

            var baseTypeName = "SchemaObject";

            if (cls.BaseClassId is { } baseId &&
                classesById.TryGetValue(baseId, out var baseCls))
            {
                baseTypeName = baseCls.Name;
            }

            sb.Append(" : ").Append(baseTypeName).AppendLine();
            sb.AppendLine("    {");

            // ctor sets Type = Schema label
            sb.AppendLine("        public " + cls.Name + "()");
            sb.AppendLine("        {");
            sb.AppendLine($"            Type = \"{cls.Label}\";");
            sb.AppendLine("        }");
            sb.AppendLine();

            var seenPropNames = new HashSet<string>(StringComparer.Ordinal);

            foreach (var prop in cls.Properties.OrderBy(p => p.Name))
            {
                if (seenPropNames.Contains(prop.Name))
                    continue;

                seenPropNames.Add(prop.Name);

                var clrType = MapRangeToClrType(prop.RangeIds, classesById, dataTypeIds);

                if (!string.IsNullOrWhiteSpace(cls.Comment))
                {
                    sb.AppendLine("    /// <summary>");

                    foreach (var line in SplitDocLines(cls.Comment!))
                        sb.AppendLine($"    /// {EscapeXmlDoc(line)}");

                    sb.AppendLine("    /// </summary>");
                }

                sb.AppendLine($"        [JsonPropertyName(\"{ExtractLocalName(prop.Id)}\")]");
                sb.AppendLine($"        public virtual {clrType} {prop.Name} {{ get; set; }}");
                sb.AppendLine();
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }


        protected virtual string MapRangeToClrType(
            List<string> rangeIds,
            IDictionary<string, SchemaClassInfo> classesById,
            ISet<string> dataTypeIds)
        {
            if (rangeIds is null || rangeIds.Count == 0)
            {
                return "object?";
            }

            if (rangeIds.Count == 1)
            {
                var rangeId = rangeIds[0];

                return rangeId switch
                {
                    "schema:Text" => "string?",
                    "schema:Boolean" => "bool?",
                    "schema:Number" => "double?",
                    "schema:DateTime" => "DateTime?",
                    "schema:Date" => "DateTime?",
                    "schema:Time" => "TimeSpan?",
                    "schema:URL" => "string?", // or "Uri?"
                    _ => MapSingleClassOrFallback(rangeId, classesById)
                };
            }

            // Multi-range / union types: you can later replace this with a Values<T1,T2> union.
            return "object?";
        }

        protected virtual string MapSingleClassOrFallback(
            string rangeId,
            IDictionary<string, SchemaClassInfo> classesById)
        {
            if (classesById.TryGetValue(rangeId, out var cls))
                return cls.Name + "?";

            return "object?";
        }

        protected virtual string EscapeXmlDoc(string text)
        {
            return text
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;");
        }

        protected virtual IEnumerable<string> SplitDocLines(string text)
        {
            // Normalize CRLF → \n
            text = text.Replace("\r\n", "\n").Replace("\r", "\n");

            foreach (var line in text.Split('\n'))
                yield return line;
        }

        protected virtual bool HasType(JsonElement element, string type)
        {
            if (!element.TryGetProperty("@type", out var t))
                return false;

            return t.ValueKind switch
            {
                JsonValueKind.String =>
                    string.Equals(t.GetString(), type, StringComparison.Ordinal),
                JsonValueKind.Array =>
                    t.EnumerateArray()
                     .Any(x => x.ValueKind == JsonValueKind.String &&
                               string.Equals(x.GetString(), type, StringComparison.Ordinal)),
                _ => false
            };
        }

        protected virtual string? GetString(JsonElement element, string name)
        {
            if (!element.TryGetProperty(name, out var v))
                return null;

            return v.ValueKind == JsonValueKind.String ? v.GetString() : null;
        }

        protected virtual List<string> GetIdList(JsonElement element, string name)
        {
            var result = new List<string>();
            if (!element.TryGetProperty(name, out var v))
                return result;

            if (v.ValueKind == JsonValueKind.Object)
            {
                if (v.TryGetProperty("@id", out var idEl) && idEl.ValueKind == JsonValueKind.String)
                {
                    var s = idEl.GetString();
                    if (!string.IsNullOrWhiteSpace(s))
                        result.Add(s!);
                }
            }
            else if (v.ValueKind == JsonValueKind.Array)
            {
                foreach (var item in v.EnumerateArray())
                {
                    if (item.ValueKind == JsonValueKind.Object &&
                        item.TryGetProperty("@id", out var idEl) &&
                        idEl.ValueKind == JsonValueKind.String)
                    {
                        var s = idEl.GetString();
                        if (!string.IsNullOrWhiteSpace(s))
                            result.Add(s!);
                    }
                }
            }

            return result;
        }

        protected virtual string ExtractLocalName(string id)
        {
            // "schema:Person" -> "Person"
            // "https://schema.org/Person" -> "Person"
            if (string.IsNullOrWhiteSpace(id))
                return id;

            var colonIdx = id.LastIndexOf(':');
            var hashIdx = id.LastIndexOf('#');
            var slashIdx = id.LastIndexOf('/');

            var idx = Math.Max(colonIdx, Math.Max(hashIdx, slashIdx));
            return idx >= 0 && idx < id.Length - 1 ? id[(idx + 1)..] : id;
        }

        protected virtual string ToPascalCase(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                return raw;

            var s = raw.Trim();

            if (s.Length == 1)
                return s.ToUpperInvariant();

            var first = char.ToUpperInvariant(s[0]);
            var rest = s[1..];

            return first + rest;
        }

        protected virtual string SanitizeIdentifier(string name)
        {
            var keywords = new HashSet<string>(StringComparer.Ordinal)
            {
                "class", "namespace", "public", "private", "protected", "internal",
                "string", "int", "long", "float", "double", "decimal", "object",
                "event", "base", "this", "new", "virtual", "override", "params",
                "ref", "out", "in", "record", "struct", "interface", "enum"
            };

            if (keywords.Contains(name))
                return name + "_";

            var sb = new StringBuilder();
            for (var i = 0; i < name.Length; i++)
            {
                var c = name[i];
                if (i == 0)
                {
                    if (char.IsLetter(c) || c == '_')
                        sb.Append(c);
                    else
                        sb.Append('_');
                }
                else
                {
                    if (char.IsLetterOrDigit(c) || c == '_')
                        sb.Append(c);
                    else
                        sb.Append('_');
                }
            }

            var result = sb.ToString();
            return string.IsNullOrEmpty(result) ? "_" : result;
        }

    }
}
