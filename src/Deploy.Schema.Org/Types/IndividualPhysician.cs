using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An individual medical practitioner. For their official address use [[address]], for affiliations to hospitals use [[hospitalAffiliation]]. 
    /// The [[practicesAt]] property can be used to indicate [[MedicalOrganization]] hospitals, clinics, pharmacies etc. where this physician practices.
    /// </summary>
    public partial class IndividualPhysician : Physician
    {
        public IndividualPhysician()
        {
            Type = "IndividualPhysician";
        }

    /// <summary>
    /// An individual medical practitioner. For their official address use [[address]], for affiliations to hospitals use [[hospitalAffiliation]]. 
    /// The [[practicesAt]] property can be used to indicate [[MedicalOrganization]] hospitals, clinics, pharmacies etc. where this physician practices.
    /// </summary>
        [JsonPropertyName("practicesAt")]
        public virtual MedicalOrganization? PracticesAt { get; set; }

    }
}
