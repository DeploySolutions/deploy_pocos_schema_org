using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    public partial class BroadcastService : Service
    {
        public BroadcastService()
        {
            Type = "BroadcastService";
        }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("area")]
        public virtual Place? Area { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("broadcastAffiliateOf")]
        public virtual Organization? BroadcastAffiliateOf { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("broadcastDisplayName")]
        public virtual string? BroadcastDisplayName { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("broadcaster")]
        public virtual Organization? Broadcaster { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("broadcastFrequency")]
        public virtual object? BroadcastFrequency { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("broadcastTimezone")]
        public virtual string? BroadcastTimezone { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("callSign")]
        public virtual string? CallSign { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("hasBroadcastChannel")]
        public virtual BroadcastChannel? HasBroadcastChannel { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("inLanguage")]
        public virtual object? InLanguage { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("parentService")]
        public virtual BroadcastService? ParentService { get; set; }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
        [JsonPropertyName("videoFormat")]
        public virtual string? VideoFormat { get; set; }

    }
}
