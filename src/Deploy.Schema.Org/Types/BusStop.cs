using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bus stop.
    /// </summary>
    public partial class BusStop : CivicStructure
    {
        public BusStop()
        {
            Type = "BusStop";
        }

    }
}
