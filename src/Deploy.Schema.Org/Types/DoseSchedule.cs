using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
    public partial class DoseSchedule : MedicalIntangible
    {
        public DoseSchedule()
        {
            Type = "DoseSchedule";
        }

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
        [JsonPropertyName("doseUnit")]
        public virtual string? DoseUnit { get; set; }

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
        [JsonPropertyName("doseValue")]
        public virtual object? DoseValue { get; set; }

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
        [JsonPropertyName("frequency")]
        public virtual string? Frequency { get; set; }

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
        [JsonPropertyName("targetPopulation")]
        public virtual string? TargetPopulation { get; set; }

    }
}
