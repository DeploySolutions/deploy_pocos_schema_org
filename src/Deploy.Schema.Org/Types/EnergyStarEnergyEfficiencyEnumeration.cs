using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Used to indicate whether a product is EnergyStar certified.
    /// </summary>
    public partial class EnergyStarEnergyEfficiencyEnumeration : EnergyEfficiencyEnumeration
    {
        public EnergyStarEnergyEfficiencyEnumeration()
        {
            Type = "EnergyStarEnergyEfficiencyEnumeration";
        }

    }
}
