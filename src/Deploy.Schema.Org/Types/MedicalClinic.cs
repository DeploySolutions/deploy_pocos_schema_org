using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A facility, often associated with a hospital or medical school, that is devoted to the specific diagnosis and/or healthcare. Previously limited to outpatients but with evolution it may be open to inpatients as well.
    /// </summary>
    public partial class MedicalClinic : MedicalOrganization
    {
        public MedicalClinic()
        {
            Type = "MedicalClinic";
        }

    /// <summary>
    /// A facility, often associated with a hospital or medical school, that is devoted to the specific diagnosis and/or healthcare. Previously limited to outpatients but with evolution it may be open to inpatients as well.
    /// </summary>
        [JsonPropertyName("availableService")]
        public virtual object? AvailableService { get; set; }

    /// <summary>
    /// A facility, often associated with a hospital or medical school, that is devoted to the specific diagnosis and/or healthcare. Previously limited to outpatients but with evolution it may be open to inpatients as well.
    /// </summary>
        [JsonPropertyName("medicalSpecialty")]
        public virtual MedicalSpecialty? MedicalSpecialty { get; set; }

    }
}
