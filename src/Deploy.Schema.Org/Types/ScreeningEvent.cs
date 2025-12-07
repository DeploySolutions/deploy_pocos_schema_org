using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
    public partial class ScreeningEvent : Event
    {
        public ScreeningEvent()
        {
            Type = "ScreeningEvent";
        }

    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
        [JsonPropertyName("subtitleLanguage")]
        public virtual object? SubtitleLanguage { get; set; }

    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
        [JsonPropertyName("videoFormat")]
        public virtual string? VideoFormat { get; set; }

    /// <summary>
    /// A screening of a movie or other video.
    /// </summary>
        [JsonPropertyName("workPresented")]
        public virtual Movie? WorkPresented { get; set; }

    }
}
