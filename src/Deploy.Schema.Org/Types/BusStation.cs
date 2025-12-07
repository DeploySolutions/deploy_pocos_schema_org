using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bus station.
    /// </summary>
    public partial class BusStation : CivicStructure
    {
        public BusStation()
        {
            Type = "BusStation";
        }

    }
}
