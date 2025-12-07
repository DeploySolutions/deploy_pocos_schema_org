using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial class RadioChannel : BroadcastChannel
    {
        public RadioChannel()
        {
            Type = "RadioChannel";
        }

    }
}
