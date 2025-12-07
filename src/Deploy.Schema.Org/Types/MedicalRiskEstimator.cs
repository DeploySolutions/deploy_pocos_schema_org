using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
    public partial class MedicalRiskEstimator : MedicalEntity
    {
        public MedicalRiskEstimator()
        {
            Type = "MedicalRiskEstimator";
        }

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
        [JsonPropertyName("estimatesRiskOf")]
        public virtual MedicalEntity? EstimatesRiskOf { get; set; }

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
        [JsonPropertyName("includedRiskFactor")]
        public virtual MedicalRiskFactor? IncludedRiskFactor { get; set; }

    }
}
