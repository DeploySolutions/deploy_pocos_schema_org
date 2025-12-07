using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// </summary>
    public partial class MedicalRiskScore : MedicalRiskEstimator
    {
        public MedicalRiskScore()
        {
            Type = "MedicalRiskScore";
        }

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// </summary>
        [JsonPropertyName("algorithm")]
        public virtual string? Algorithm { get; set; }

    }
}
