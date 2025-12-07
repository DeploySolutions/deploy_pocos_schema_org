using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
    public partial class HealthInsurancePlan : Intangible
    {
        public HealthInsurancePlan()
        {
            Type = "HealthInsurancePlan";
        }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("benefitsSummaryUrl")]
        public virtual string? BenefitsSummaryUrl { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("contactPoint")]
        public virtual ContactPoint? ContactPoint { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("healthPlanDrugOption")]
        public virtual string? HealthPlanDrugOption { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("healthPlanDrugTier")]
        public virtual string? HealthPlanDrugTier { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("healthPlanId")]
        public virtual string? HealthPlanId { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("healthPlanMarketingUrl")]
        public virtual string? HealthPlanMarketingUrl { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("includesHealthPlanFormulary")]
        public virtual HealthPlanFormulary? IncludesHealthPlanFormulary { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("includesHealthPlanNetwork")]
        public virtual HealthPlanNetwork? IncludesHealthPlanNetwork { get; set; }

    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// </summary>
        [JsonPropertyName("usesHealthPlanIdStandard")]
        public virtual object? UsesHealthPlanIdStandard { get; set; }

    }
}
