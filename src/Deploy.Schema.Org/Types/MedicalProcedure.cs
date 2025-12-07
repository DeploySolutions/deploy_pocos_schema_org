using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
    public partial class MedicalProcedure : MedicalEntity
    {
        public MedicalProcedure()
        {
            Type = "MedicalProcedure";
        }

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
        [JsonPropertyName("bodyLocation")]
        public virtual string? BodyLocation { get; set; }

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
        [JsonPropertyName("followup")]
        public virtual string? Followup { get; set; }

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
        [JsonPropertyName("howPerformed")]
        public virtual string? HowPerformed { get; set; }

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
        [JsonPropertyName("preparation")]
        public virtual object? Preparation { get; set; }

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
        [JsonPropertyName("procedureType")]
        public virtual MedicalProcedureType? ProcedureType { get; set; }

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
        [JsonPropertyName("status")]
        public virtual object? Status { get; set; }

    }
}
