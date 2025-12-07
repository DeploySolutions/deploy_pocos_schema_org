using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
    public partial class BroadcastFrequencySpecification : Intangible
    {
        public BroadcastFrequencySpecification()
        {
            Type = "BroadcastFrequencySpecification";
        }

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
        [JsonPropertyName("broadcastFrequencyValue")]
        public virtual object? BroadcastFrequencyValue { get; set; }

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
        [JsonPropertyName("broadcastSignalModulation")]
        public virtual object? BroadcastSignalModulation { get; set; }

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
        [JsonPropertyName("broadcastSubChannel")]
        public virtual string? BroadcastSubChannel { get; set; }

    }
}
