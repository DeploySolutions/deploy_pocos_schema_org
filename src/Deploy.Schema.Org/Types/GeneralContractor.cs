using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A general contractor.
    /// </summary>
    public partial class GeneralContractor : HomeAndConstructionBusiness
    {
        public GeneralContractor()
        {
            Type = "GeneralContractor";
        }

    }
}
