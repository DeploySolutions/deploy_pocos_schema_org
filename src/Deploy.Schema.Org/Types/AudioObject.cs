using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An audio file.
    /// </summary>
    public partial class AudioObject : MediaObject
    {
        public AudioObject()
        {
            Type = "AudioObject";
        }

    /// <summary>
    /// An audio file.
    /// </summary>
        [JsonPropertyName("caption")]
        public virtual object? Caption { get; set; }

    /// <summary>
    /// An audio file.
    /// </summary>
        [JsonPropertyName("embeddedTextCaption")]
        public virtual string? EmbeddedTextCaption { get; set; }

    /// <summary>
    /// An audio file.
    /// </summary>
        [JsonPropertyName("transcript")]
        public virtual string? Transcript { get; set; }

    }
}
