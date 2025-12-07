using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// For a given health insurance plan, the specification for costs and coverage of prescription drugs.
    /// </summary>
    public partial class HealthPlanFormulary : Intangible
    {
        public HealthPlanFormulary()
        {
            Type = "HealthPlanFormulary";
        }

    /// <summary>
    /// For a given health insurance plan, the specification for costs and coverage of prescription drugs.
    /// </summary>
        [JsonPropertyName("healthPlanCostSharing")]
        public virtual bool? HealthPlanCostSharing { get; set; }

    /// <summary>
    /// For a given health insurance plan, the specification for costs and coverage of prescription drugs.
    /// </summary>
        [JsonPropertyName("healthPlanDrugTier")]
        public virtual string? HealthPlanDrugTier { get; set; }

    /// <summary>
    /// For a given health insurance plan, the specification for costs and coverage of prescription drugs.
    /// </summary>
        [JsonPropertyName("offersPrescriptionByMail")]
        public virtual bool? OffersPrescriptionByMail { get; set; }

    }
}
