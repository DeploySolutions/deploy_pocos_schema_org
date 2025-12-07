using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    public partial class DrugLegalStatus : MedicalIntangible
    {
        public DrugLegalStatus()
        {
            Type = "DrugLegalStatus";
        }

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
        [JsonPropertyName("applicableLocation")]
        public virtual AdministrativeArea? ApplicableLocation { get; set; }

    }
}
