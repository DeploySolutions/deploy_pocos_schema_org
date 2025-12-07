using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    public partial class Diet : CreativeWork
    {
        public Diet()
        {
            Type = "Diet";
        }

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
        [JsonPropertyName("dietFeatures")]
        public virtual string? DietFeatures { get; set; }

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
        [JsonPropertyName("endorsers")]
        public virtual object? Endorsers { get; set; }

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
        [JsonPropertyName("expertConsiderations")]
        public virtual string? ExpertConsiderations { get; set; }

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
        [JsonPropertyName("physiologicalBenefits")]
        public virtual string? PhysiologicalBenefits { get; set; }

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
        [JsonPropertyName("risks")]
        public virtual string? Risks { get; set; }

    }
}
