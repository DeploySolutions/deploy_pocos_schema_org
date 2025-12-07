using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
    public partial class Patient : Person
    {
        public Patient()
        {
            Type = "Patient";
        }

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
        [JsonPropertyName("diagnosis")]
        public virtual MedicalCondition? Diagnosis { get; set; }

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
        [JsonPropertyName("drug")]
        public virtual Drug? Drug { get; set; }

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
        [JsonPropertyName("healthCondition")]
        public virtual MedicalCondition? HealthCondition { get; set; }

    }
}
