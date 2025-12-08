using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Represents a base class for Schema.org objects, providing serialization and deserialization capabilities for JSON-LD.
    /// <seealso ref="https://schema.org/docs/schemas.html"/>
    /// </summary>
    public abstract partial class SchemaObject
    {
        private static readonly JsonSerializerOptions _jsonLdOptions = new()
        {
            WriteIndented = false,
            PropertyNamingPolicy = null,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        public const string SchemaOrgVersion = "29.1";

        /// <summary>
        /// Gets or sets the JSON-LD context for the Schema.org object.
        /// Defaults to "https://schema.org".
        /// </summary>
        [JsonPropertyName("@context")]
        public virtual string Context { get; set; } = "https://schema.org";

        /// <summary>
        /// Gets the type of the Schema.org object.
        /// This property is protected and can only be set by derived classes.
        /// </summary>
        [JsonPropertyName("@type")]
        public virtual string Type { get; protected set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the Schema.org object.
        /// </summary>
        [JsonPropertyName("@id")]
        public virtual string? Id { get; set; }

        /// <summary>
        /// Serializes this instance to a JSON-LD string.
        /// </summary>
        /// <returns>A JSON-LD formatted string representing this object.</returns>
        public string ToJsonLd()
        {
            return JsonSerializer.Serialize((object)this, _jsonLdOptions);
            // or: return JsonSerializer.Serialize(this, GetType(), _jsonLdOptions);
        }

        // Optional helper for debugging
        public string ToPrettyJsonLd()
            => JsonSerializer.Serialize((object)this, new JsonSerializerOptions(_jsonLdOptions)
            {
                WriteIndented = true
            });

        /// <summary>
        /// Writes the JSON-LD representation of this instance to the specified stream.
        /// </summary>
        /// <param name="stream">The stream to write the JSON-LD data to.</param>
        public virtual void WriteJsonLd(Stream stream)
        {
            using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            JsonSerializer.Serialize(writer, (object)this, _jsonLdOptions);
        }

        /// <summary>
        /// Deserializes a JSON-LD string into an instance of the specified SchemaObject type.
        /// </summary>
        /// <typeparam name="T">The type of SchemaObject to deserialize into.</typeparam>
        /// <param name="json">The JSON-LD string to deserialize.</param>
        /// <returns>An instance of the specified SchemaObject type, or null if deserialization fails.</returns>
        public static T? FromJsonLd<T>(string json) where T : SchemaObject
        {
            return JsonSerializer.Deserialize<T>(json, _jsonLdOptions);
        }
    }
}
