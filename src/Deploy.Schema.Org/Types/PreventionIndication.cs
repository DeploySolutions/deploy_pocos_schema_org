using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An indication for preventing an underlying condition, symptom, etc.
    /// </summary>
    public partial class PreventionIndication : MedicalIndication
    {
        public PreventionIndication()
        {
            Type = "PreventionIndication";
        }

    }
}
