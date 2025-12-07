using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
    public partial class MedicalDevice : MedicalEntity
    {
        public MedicalDevice()
        {
            Type = "MedicalDevice";
        }

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
        [JsonPropertyName("adverseOutcome")]
        public virtual MedicalEntity? AdverseOutcome { get; set; }

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
        [JsonPropertyName("contraindication")]
        public virtual object? Contraindication { get; set; }

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
        [JsonPropertyName("postOp")]
        public virtual string? PostOp { get; set; }

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
        [JsonPropertyName("preOp")]
        public virtual string? PreOp { get; set; }

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
        [JsonPropertyName("procedure")]
        public virtual string? Procedure { get; set; }

    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// </summary>
        [JsonPropertyName("seriousAdverseOutcome")]
        public virtual MedicalEntity? SeriousAdverseOutcome { get; set; }

    }
}
