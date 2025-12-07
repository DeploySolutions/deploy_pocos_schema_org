using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    public partial class Brand : Intangible
    {
        public Brand()
        {
            Type = "Brand";
        }

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
        [JsonPropertyName("aggregateRating")]
        public virtual AggregateRating? AggregateRating { get; set; }

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
        [JsonPropertyName("logo")]
        public virtual object? Logo { get; set; }

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
        [JsonPropertyName("review")]
        public virtual Review? Review { get; set; }

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
        [JsonPropertyName("slogan")]
        public virtual string? Slogan { get; set; }

    }
}
