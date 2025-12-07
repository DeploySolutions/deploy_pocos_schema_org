using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates energy efficiency levels (also known as "classes" or "ratings") and certifications that are part of several international energy efficiency standards.
    /// </summary>
    public partial class EnergyEfficiencyEnumeration : Enumeration
    {
        public EnergyEfficiencyEnumeration()
        {
            Type = "EnergyEfficiencyEnumeration";
        }

    }
}
