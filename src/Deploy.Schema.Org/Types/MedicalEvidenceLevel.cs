using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Level of evidence for a medical guideline. Enumerated type.
    /// </summary>
    public partial class MedicalEvidenceLevel : MedicalEnumeration
    {
        public MedicalEvidenceLevel()
        {
            Type = "MedicalEvidenceLevel";
        }

    }
}
