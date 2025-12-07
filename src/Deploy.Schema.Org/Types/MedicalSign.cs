using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    public partial class MedicalSign : MedicalSignOrSymptom
    {
        public MedicalSign()
        {
            Type = "MedicalSign";
        }

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
        [JsonPropertyName("identifyingExam")]
        public virtual PhysicalExam? IdentifyingExam { get; set; }

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
        [JsonPropertyName("identifyingTest")]
        public virtual MedicalTest? IdentifyingTest { get; set; }

    }
}
