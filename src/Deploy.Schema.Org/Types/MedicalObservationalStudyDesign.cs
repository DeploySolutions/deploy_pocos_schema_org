using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Design models for observational medical studies. Enumerated type.
    /// </summary>
    public partial class MedicalObservationalStudyDesign : MedicalEnumeration
    {
        public MedicalObservationalStudyDesign()
        {
            Type = "MedicalObservationalStudyDesign";
        }

    }
}
