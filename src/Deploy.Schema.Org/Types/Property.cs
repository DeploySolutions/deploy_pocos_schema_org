using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
    public partial class Property : Intangible
    {
        public Property()
        {
            Type = "Property";
        }

    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
        [JsonPropertyName("domainIncludes")]
        public virtual Class? DomainIncludes { get; set; }

    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
        [JsonPropertyName("inverseOf")]
        public virtual Property? InverseOf { get; set; }

    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
        [JsonPropertyName("rangeIncludes")]
        public virtual Class? RangeIncludes { get; set; }

    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
        [JsonPropertyName("supersededBy")]
        public virtual object? SupersededBy { get; set; }

    }
}
