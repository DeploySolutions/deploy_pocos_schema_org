using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Target audiences for medical web pages.
    /// </summary>
    public partial class MedicalAudience : PeopleAudience
    {
        public MedicalAudience()
        {
            Type = "MedicalAudience";
        }

    }
}
