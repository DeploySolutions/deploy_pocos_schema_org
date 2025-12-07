using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    public partial class Thing : SchemaObject
    {
        public Thing()
        {
            Type = "Thing";
        }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("additionalType")]
        public virtual object? AdditionalType { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("alternateName")]
        public virtual string? AlternateName { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("description")]
        public virtual object? Description { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("disambiguatingDescription")]
        public virtual string? DisambiguatingDescription { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("identifier")]
        public virtual object? Identifier { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("image")]
        public virtual object? Image { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("mainEntityOfPage")]
        public virtual object? MainEntityOfPage { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("name")]
        public virtual string? Name { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("potentialAction")]
        public virtual Action? PotentialAction { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("sameAs")]
        public virtual string? SameAs { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("subjectOf")]
        public virtual object? SubjectOf { get; set; }

    /// <summary>
    /// The most generic type of item.
    /// </summary>
        [JsonPropertyName("url")]
        public virtual string? Url { get; set; }

    }
}
