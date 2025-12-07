using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A government building.
    /// </summary>
    public partial class GovernmentBuilding : CivicStructure
    {
        public GovernmentBuilding()
        {
            Type = "GovernmentBuilding";
        }

    }
}
