using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial class BroadcastChannel : Intangible
    {
        public BroadcastChannel()
        {
            Type = "BroadcastChannel";
        }

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
        [JsonPropertyName("broadcastChannelId")]
        public virtual string? BroadcastChannelId { get; set; }

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
        [JsonPropertyName("broadcastFrequency")]
        public virtual object? BroadcastFrequency { get; set; }

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
        [JsonPropertyName("broadcastServiceTier")]
        public virtual string? BroadcastServiceTier { get; set; }

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
        [JsonPropertyName("genre")]
        public virtual object? Genre { get; set; }

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
        [JsonPropertyName("inBroadcastLineup")]
        public virtual CableOrSatelliteService? InBroadcastLineup { get; set; }

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
        [JsonPropertyName("providesBroadcastService")]
        public virtual BroadcastService? ProvidesBroadcastService { get; set; }

    }
}
