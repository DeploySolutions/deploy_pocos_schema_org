using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A hospital.
    /// </summary>
    public partial class Hospital : CivicStructure
    {
        public Hospital()
        {
            Type = "Hospital";
        }

    /// <summary>
    /// A hospital.
    /// </summary>
        [JsonPropertyName("availableService")]
        public virtual object? AvailableService { get; set; }

    /// <summary>
    /// A hospital.
    /// </summary>
        [JsonPropertyName("healthcareReportingData")]
        public virtual object? HealthcareReportingData { get; set; }

    /// <summary>
    /// A hospital.
    /// </summary>
        [JsonPropertyName("medicalSpecialty")]
        public virtual MedicalSpecialty? MedicalSpecialty { get; set; }

    }
}
