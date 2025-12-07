using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A particular physical or virtual business of an organization for medical purposes. Examples of MedicalBusiness include different businesses run by health professionals.
    /// </summary>
    public partial class MedicalBusiness : LocalBusiness
    {
        public MedicalBusiness()
        {
            Type = "MedicalBusiness";
        }

    }
}
