using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Categories that represent an assessment of the risk of fetal injury due to a drug or pharmaceutical used as directed by the mother during pregnancy.
    /// </summary>
    public partial class DrugPregnancyCategory : MedicalEnumeration
    {
        public DrugPregnancyCategory()
        {
            Type = "DrugPregnancyCategory";
        }

    }
}
