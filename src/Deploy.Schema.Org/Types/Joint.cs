using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    public partial class Joint : AnatomicalStructure
    {
        public Joint()
        {
            Type = "Joint";
        }

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
        [JsonPropertyName("biomechnicalClass")]
        public virtual string? BiomechnicalClass { get; set; }

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
        [JsonPropertyName("functionalClass")]
        public virtual object? FunctionalClass { get; set; }

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
        [JsonPropertyName("structuralClass")]
        public virtual string? StructuralClass { get; set; }

    }
}
