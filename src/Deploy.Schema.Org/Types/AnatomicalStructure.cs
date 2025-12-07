using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
    public partial class AnatomicalStructure : MedicalEntity
    {
        public AnatomicalStructure()
        {
            Type = "AnatomicalStructure";
        }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("associatedPathophysiology")]
        public virtual string? AssociatedPathophysiology { get; set; }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("bodyLocation")]
        public virtual string? BodyLocation { get; set; }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("connectedTo")]
        public virtual AnatomicalStructure? ConnectedTo { get; set; }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("diagram")]
        public virtual ImageObject? Diagram { get; set; }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("partOfSystem")]
        public virtual AnatomicalSystem? PartOfSystem { get; set; }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("relatedCondition")]
        public virtual MedicalCondition? RelatedCondition { get; set; }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("relatedTherapy")]
        public virtual MedicalTherapy? RelatedTherapy { get; set; }

    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// </summary>
        [JsonPropertyName("subStructure")]
        public virtual AnatomicalStructure? SubStructure { get; set; }

    }
}
