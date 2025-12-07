using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The status of a medical study. Enumerated type.
    /// </summary>
    public partial class MedicalStudyStatus : MedicalEnumeration
    {
        public MedicalStudyStatus()
        {
            Type = "MedicalStudyStatus";
        }

    }
}
