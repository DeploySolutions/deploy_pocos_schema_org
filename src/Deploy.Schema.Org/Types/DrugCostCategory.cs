using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerated categories of medical drug costs.
    /// </summary>
    public partial class DrugCostCategory : MedicalEnumeration
    {
        public DrugCostCategory()
        {
            Type = "DrugCostCategory";
        }

    }
}
