using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Design models for medical trials. Enumerated type.
    /// </summary>
    public partial class MedicalTrialDesign : MedicalEnumeration
    {
        public MedicalTrialDesign()
        {
            Type = "MedicalTrialDesign";
        }

    }
}
