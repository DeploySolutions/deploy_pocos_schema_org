using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
    public partial class MedicalCondition : MedicalEntity
    {
        public MedicalCondition()
        {
            Type = "MedicalCondition";
        }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("associatedAnatomy")]
        public virtual object? AssociatedAnatomy { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("differentialDiagnosis")]
        public virtual DDxElement? DifferentialDiagnosis { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("drug")]
        public virtual Drug? Drug { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("epidemiology")]
        public virtual string? Epidemiology { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("expectedPrognosis")]
        public virtual string? ExpectedPrognosis { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("naturalProgression")]
        public virtual string? NaturalProgression { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("pathophysiology")]
        public virtual string? Pathophysiology { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("possibleComplication")]
        public virtual string? PossibleComplication { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("possibleTreatment")]
        public virtual MedicalTherapy? PossibleTreatment { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("primaryPrevention")]
        public virtual MedicalTherapy? PrimaryPrevention { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("riskFactor")]
        public virtual MedicalRiskFactor? RiskFactor { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("secondaryPrevention")]
        public virtual MedicalTherapy? SecondaryPrevention { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("signOrSymptom")]
        public virtual MedicalSignOrSymptom? SignOrSymptom { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("stage")]
        public virtual MedicalConditionStage? Stage { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("status")]
        public virtual object? Status { get; set; }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
        [JsonPropertyName("typicalTest")]
        public virtual MedicalTest? TypicalTest { get; set; }

    }
}
