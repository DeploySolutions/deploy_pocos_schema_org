using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any complaint sensed and expressed by the patient (therefore defined as subjective)  like stomachache, lower-back pain, or fatigue.
    /// </summary>
    public partial class MedicalSymptom : MedicalSignOrSymptom
    {
        public MedicalSymptom()
        {
            Type = "MedicalSymptom";
        }

    }
}
