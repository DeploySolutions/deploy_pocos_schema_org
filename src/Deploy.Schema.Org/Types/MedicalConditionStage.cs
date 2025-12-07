using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    public partial class MedicalConditionStage : MedicalIntangible
    {
        public MedicalConditionStage()
        {
            Type = "MedicalConditionStage";
        }

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
        [JsonPropertyName("stageAsNumber")]
        public virtual double? StageAsNumber { get; set; }

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
        [JsonPropertyName("subStageSuffix")]
        public virtual string? SubStageSuffix { get; set; }

    }
}
