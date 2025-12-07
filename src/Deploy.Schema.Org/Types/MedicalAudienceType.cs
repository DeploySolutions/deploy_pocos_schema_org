using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Target audiences types for medical web pages. Enumerated type.
    /// </summary>
    public partial class MedicalAudienceType : MedicalEnumeration
    {
        public MedicalAudienceType()
        {
            Type = "MedicalAudienceType";
        }

    }
}
