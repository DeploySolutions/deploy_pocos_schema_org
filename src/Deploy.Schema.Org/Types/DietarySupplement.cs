using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
    public partial class DietarySupplement : Substance
    {
        public DietarySupplement()
        {
            Type = "DietarySupplement";
        }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("activeIngredient")]
        public virtual string? ActiveIngredient { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("isProprietary")]
        public virtual bool? IsProprietary { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("legalStatus")]
        public virtual object? LegalStatus { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("maximumIntake")]
        public virtual MaximumDoseSchedule? MaximumIntake { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("mechanismOfAction")]
        public virtual string? MechanismOfAction { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("nonProprietaryName")]
        public virtual string? NonProprietaryName { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("proprietaryName")]
        public virtual string? ProprietaryName { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("recommendedIntake")]
        public virtual RecommendedDoseSchedule? RecommendedIntake { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("safetyConsideration")]
        public virtual string? SafetyConsideration { get; set; }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
        [JsonPropertyName("targetPopulation")]
        public virtual string? TargetPopulation { get; set; }

    }
}
