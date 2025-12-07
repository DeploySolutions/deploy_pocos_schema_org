using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    public partial class LegislativeBuilding : GovernmentBuilding
    {
        public LegislativeBuilding()
        {
            Type = "LegislativeBuilding";
        }

    }
}
