using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A video file.
    /// </summary>
    public partial class VideoObject : MediaObject
    {
        public VideoObject()
        {
            Type = "VideoObject";
        }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("caption")]
        public virtual object? Caption { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("embeddedTextCaption")]
        public virtual string? EmbeddedTextCaption { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("transcript")]
        public virtual string? Transcript { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("videoFrameSize")]
        public virtual string? VideoFrameSize { get; set; }

    /// <summary>
    /// A video file.
    /// </summary>
        [JsonPropertyName("videoQuality")]
        public virtual string? VideoQuality { get; set; }

    }
}
