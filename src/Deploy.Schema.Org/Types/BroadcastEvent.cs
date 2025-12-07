using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    public partial class BroadcastEvent : PublicationEvent
    {
        public BroadcastEvent()
        {
            Type = "BroadcastEvent";
        }

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
        [JsonPropertyName("broadcastOfEvent")]
        public virtual Event? BroadcastOfEvent { get; set; }

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
        [JsonPropertyName("isLiveBroadcast")]
        public virtual bool? IsLiveBroadcast { get; set; }

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
        [JsonPropertyName("subtitleLanguage")]
        public virtual object? SubtitleLanguage { get; set; }

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
        [JsonPropertyName("videoFormat")]
        public virtual string? VideoFormat { get; set; }

    }
}
