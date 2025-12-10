using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// </summary>
    public partial class AlignmentObject : Intangible
    {
        public AlignmentObject()
        {
            Type = "AlignmentObject";
        }

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// </summary>
        [JsonPropertyName("alignmentType")]
        public virtual string? AlignmentType { get; set; }

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// </summary>
        [JsonPropertyName("educationalFramework")]
        public virtual string? EducationalFramework { get; set; }

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// </summary>
        [JsonPropertyName("targetDescription")]
        public virtual string? TargetDescription { get; set; }

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// </summary>
        [JsonPropertyName("targetName")]
        public virtual string? TargetName { get; set; }

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// </summary>
        [JsonPropertyName("targetUrl")]
        public virtual string? TargetUrl { get; set; }

    }
}
