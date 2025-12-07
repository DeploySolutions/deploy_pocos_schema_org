using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An indication for treating an underlying condition, symptom, etc.
    /// </summary>
    public partial class TreatmentIndication : MedicalIndication
    {
        public TreatmentIndication()
        {
            Type = "TreatmentIndication";
        }

    }
}
