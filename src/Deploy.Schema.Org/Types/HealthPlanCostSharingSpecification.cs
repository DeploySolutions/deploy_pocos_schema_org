using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// </summary>
    public partial class HealthPlanCostSharingSpecification : Intangible
    {
        public HealthPlanCostSharingSpecification()
        {
            Type = "HealthPlanCostSharingSpecification";
        }

    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// </summary>
        [JsonPropertyName("healthPlanCoinsuranceOption")]
        public virtual string? HealthPlanCoinsuranceOption { get; set; }

    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// </summary>
        [JsonPropertyName("healthPlanCoinsuranceRate")]
        public virtual double? HealthPlanCoinsuranceRate { get; set; }

    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// </summary>
        [JsonPropertyName("healthPlanCopay")]
        public virtual PriceSpecification? HealthPlanCopay { get; set; }

    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// </summary>
        [JsonPropertyName("healthPlanCopayOption")]
        public virtual string? HealthPlanCopayOption { get; set; }

    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// </summary>
        [JsonPropertyName("healthPlanPharmacyCategory")]
        public virtual string? HealthPlanPharmacyCategory { get; set; }

    }
}
