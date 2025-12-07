using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A musical composition.
    /// </summary>
    public partial class MusicComposition : CreativeWork
    {
        public MusicComposition()
        {
            Type = "MusicComposition";
        }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("composer")]
        public virtual object? Composer { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("firstPerformance")]
        public virtual Event? FirstPerformance { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("includedComposition")]
        public virtual MusicComposition? IncludedComposition { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("iswcCode")]
        public virtual string? IswcCode { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("lyricist")]
        public virtual Person? Lyricist { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("lyrics")]
        public virtual CreativeWork? Lyrics { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("musicalKey")]
        public virtual string? MusicalKey { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("musicArrangement")]
        public virtual MusicComposition? MusicArrangement { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("musicCompositionForm")]
        public virtual string? MusicCompositionForm { get; set; }

    /// <summary>
    /// A musical composition.
    /// </summary>
        [JsonPropertyName("recordedAs")]
        public virtual MusicRecording? RecordedAs { get; set; }

    }
}
