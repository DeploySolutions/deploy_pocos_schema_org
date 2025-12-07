using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any feature associated or not with a medical condition. In medicine a symptom is generally subjective while a sign is objective.
    /// </summary>
    public partial class MedicalSignOrSymptom : MedicalCondition
    {
        public MedicalSignOrSymptom()
        {
            Type = "MedicalSignOrSymptom";
        }

    /// <summary>
    /// Any feature associated or not with a medical condition. In medicine a symptom is generally subjective while a sign is objective.
    /// </summary>
        [JsonPropertyName("possibleTreatment")]
        public virtual MedicalTherapy? PossibleTreatment { get; set; }

    }
}
