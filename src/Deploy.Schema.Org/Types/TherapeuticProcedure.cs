using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
    public partial class TherapeuticProcedure : MedicalProcedure
    {
        public TherapeuticProcedure()
        {
            Type = "TherapeuticProcedure";
        }

    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
        [JsonPropertyName("adverseOutcome")]
        public virtual MedicalEntity? AdverseOutcome { get; set; }

    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
        [JsonPropertyName("doseSchedule")]
        public virtual DoseSchedule? DoseSchedule { get; set; }

    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
        [JsonPropertyName("drug")]
        public virtual Drug? Drug { get; set; }

    }
}
