using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial class TelevisionChannel : BroadcastChannel
    {
        public TelevisionChannel()
        {
            Type = "TelevisionChannel";
        }

    }
}
