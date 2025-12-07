using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An individual physician or a physician's office considered as a [[MedicalOrganization]].
    /// </summary>
    public partial class Physician : MedicalBusiness
    {
        public Physician()
        {
            Type = "Physician";
        }

    /// <summary>
    /// An individual physician or a physician's office considered as a [[MedicalOrganization]].
    /// </summary>
        [JsonPropertyName("availableService")]
        public virtual object? AvailableService { get; set; }

    /// <summary>
    /// An individual physician or a physician's office considered as a [[MedicalOrganization]].
    /// </summary>
        [JsonPropertyName("hospitalAffiliation")]
        public virtual Hospital? HospitalAffiliation { get; set; }

    /// <summary>
    /// An individual physician or a physician's office considered as a [[MedicalOrganization]].
    /// </summary>
        [JsonPropertyName("medicalSpecialty")]
        public virtual MedicalSpecialty? MedicalSpecialty { get; set; }

    /// <summary>
    /// An individual physician or a physician's office considered as a [[MedicalOrganization]].
    /// </summary>
        [JsonPropertyName("occupationalCategory")]
        public virtual object? OccupationalCategory { get; set; }

    /// <summary>
    /// An individual physician or a physician's office considered as a [[MedicalOrganization]].
    /// </summary>
        [JsonPropertyName("usNPI")]
        public virtual string? UsNPI { get; set; }

    }
}
