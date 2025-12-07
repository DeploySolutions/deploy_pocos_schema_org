// Program.cs
// Usage: dotnet run -- <path-to-schemaorg-jsonld> <output-folder>

using GenerateSchemaOrgPocos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SchemaOrgPocoGen
{
    internal static class Program
    {
        
        public static int Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: SchemaOrgPocoGen <path-to-schemaorg-jsonld> <output-folder>");
                return 1;
            }

            var jsonLdPath = Path.GetFullPath(args[0]);
            var outputRoot = Path.GetFullPath(args[1]);

            if (!File.Exists(jsonLdPath))
            {
                Console.WriteLine($"Input file not found: {jsonLdPath}");
                return 1;
            }

            Directory.CreateDirectory(outputRoot);

            Console.WriteLine($"Loading JSON-LD from: {jsonLdPath}");

            SchemaOrgPocoGenerator generator = new SchemaOrgPocoGenerator();

            using var stream = File.OpenRead(jsonLdPath);
            using var doc = JsonDocument.Parse(stream);

            var root = doc.RootElement;
            if (!root.TryGetProperty("@graph", out var graph) || graph.ValueKind != JsonValueKind.Array)
            {
                Console.WriteLine("Invalid JSON-LD: missing @graph array.");
                return 1;
            }

            // --- Step 1: Collect data type IDs (Text, Boolean, Date, etc.) ----------
            var dataTypeIds = new HashSet<string>(StringComparer.Ordinal);

            foreach (var node in graph.EnumerateArray())
            {
                if (generator.HasType(node, "schema:DataType"))
                {
                    var id = generator.GetString(node, "@id");
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
                if (!generator.HasType(node, "rdfs:Class"))
                    continue;

                var id = generator.GetString(node, "@id");
                if (string.IsNullOrWhiteSpace(id))
                    continue;

                if (dataTypeIds.Contains(id!))
                {
                    // We'll map these to primitives, not POCOs.
                    continue;
                }
                if (id == "schema:URL")
                    continue;

                var label = generator.GetString(node, "rdfs:label") ?? generator.ExtractLocalName(id!);
                var name = generator.SanitizeIdentifier(generator.ToPascalCase(label));
                var comment = generator.GetString(node, "rdfs:comment");

                string? baseId = null;
                if (node.TryGetProperty("rdfs:subClassOf", out var subEl))
                {
                    if (subEl.ValueKind == JsonValueKind.Object)
                    {
                        baseId = generator.GetString(subEl, "@id");
                    }
                    else if (subEl.ValueKind == JsonValueKind.Array)
                    {
                        // If multiple inheritance, just pick the first listed base.
                        foreach (var item in subEl.EnumerateArray())
                        {
                            var cid = generator.GetString(item, "@id");
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
                if (!generator.HasType(node, "rdf:Property"))
                    continue;

                var id = generator.GetString(node, "@id");
                if (string.IsNullOrWhiteSpace(id))
                    continue;

                var label = generator.GetString(node, "rdfs:label") ?? generator.ExtractLocalName(id!);
                var propName = generator.SanitizeIdentifier(generator.ToPascalCase(label));
                var comment = generator.GetString(node, "rdfs:comment");

                var domains = generator.GetIdList(node, "schema:domainIncludes");
                var ranges = generator.GetIdList(node, "schema:rangeIncludes");

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
                var code = generator.GenerateClassCode(cls, classesById, dataTypeIds);
                var fileName = cls.Name + ".cs";
                var path = Path.Combine(outputRoot, fileName);
                File.WriteAllText(path, code, Encoding.UTF8);
                Console.WriteLine($"Generated: {fileName}");
            }


            Console.WriteLine("Done.");
            return 0;
        }

    }
}
