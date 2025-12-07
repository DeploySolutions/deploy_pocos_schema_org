using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type, e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    public partial class PublicationEvent : Event
    {
        public PublicationEvent()
        {
            Type = "PublicationEvent";
        }

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type, e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
        [JsonPropertyName("free")]
        public virtual bool? Free { get; set; }

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type, e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
        [JsonPropertyName("publishedBy")]
        public virtual object? PublishedBy { get; set; }

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type, e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
        [JsonPropertyName("publishedOn")]
        public virtual BroadcastService? PublishedOn { get; set; }

    }
}
