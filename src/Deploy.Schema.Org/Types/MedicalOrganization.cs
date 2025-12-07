using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
    public partial class MedicalOrganization : Organization
    {
        public MedicalOrganization()
        {
            Type = "MedicalOrganization";
        }

    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
        [JsonPropertyName("healthPlanNetworkId")]
        public virtual string? HealthPlanNetworkId { get; set; }

    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
        [JsonPropertyName("isAcceptingNewPatients")]
        public virtual bool? IsAcceptingNewPatients { get; set; }

    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// </summary>
        [JsonPropertyName("medicalSpecialty")]
        public virtual MedicalSpecialty? MedicalSpecialty { get; set; }

    }
}
