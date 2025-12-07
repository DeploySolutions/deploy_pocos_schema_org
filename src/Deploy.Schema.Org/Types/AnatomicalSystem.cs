using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can include circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
    public partial class AnatomicalSystem : MedicalEntity
    {
        public AnatomicalSystem()
        {
            Type = "AnatomicalSystem";
        }

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can include circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
        [JsonPropertyName("associatedPathophysiology")]
        public virtual string? AssociatedPathophysiology { get; set; }

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can include circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
        [JsonPropertyName("comprisedOf")]
        public virtual object? ComprisedOf { get; set; }

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can include circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
        [JsonPropertyName("relatedCondition")]
        public virtual MedicalCondition? RelatedCondition { get; set; }

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can include circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
        [JsonPropertyName("relatedStructure")]
        public virtual AnatomicalStructure? RelatedStructure { get; set; }

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can include circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
        [JsonPropertyName("relatedTherapy")]
        public virtual MedicalTherapy? RelatedTherapy { get; set; }

    }
}
