using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A US-style health insurance plan network.
    /// </summary>
    public partial class HealthPlanNetwork : Intangible
    {
        public HealthPlanNetwork()
        {
            Type = "HealthPlanNetwork";
        }

    /// <summary>
    /// A US-style health insurance plan network.
    /// </summary>
        [JsonPropertyName("healthPlanCostSharing")]
        public virtual bool? HealthPlanCostSharing { get; set; }

    /// <summary>
    /// A US-style health insurance plan network.
    /// </summary>
        [JsonPropertyName("healthPlanNetworkId")]
        public virtual string? HealthPlanNetworkId { get; set; }

    /// <summary>
    /// A US-style health insurance plan network.
    /// </summary>
        [JsonPropertyName("healthPlanNetworkTier")]
        public virtual string? HealthPlanNetworkTier { get; set; }

    }
}
