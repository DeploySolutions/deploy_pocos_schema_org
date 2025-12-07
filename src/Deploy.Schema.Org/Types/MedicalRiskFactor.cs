using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
    public partial class MedicalRiskFactor : MedicalEntity
    {
        public MedicalRiskFactor()
        {
            Type = "MedicalRiskFactor";
        }

    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
        [JsonPropertyName("increasesRiskOf")]
        public virtual MedicalEntity? IncreasesRiskOf { get; set; }

    }
}
