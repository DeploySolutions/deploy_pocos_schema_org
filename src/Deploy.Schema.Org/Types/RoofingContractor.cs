using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A roofing contractor.
    /// </summary>
    public partial class RoofingContractor : HomeAndConstructionBusiness
    {
        public RoofingContractor()
        {
            Type = "RoofingContractor";
        }

    }
}
