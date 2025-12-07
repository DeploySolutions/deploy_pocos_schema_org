using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// </summary>
    public partial class MedicalGuidelineRecommendation : MedicalGuideline
    {
        public MedicalGuidelineRecommendation()
        {
            Type = "MedicalGuidelineRecommendation";
        }

    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// </summary>
        [JsonPropertyName("recommendationStrength")]
        public virtual string? RecommendationStrength { get; set; }

    }
}
