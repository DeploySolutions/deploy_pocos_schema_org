using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    public partial class Clip : CreativeWork
    {
        public Clip()
        {
            Type = "Clip";
        }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("clipNumber")]
        public virtual object? ClipNumber { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("endOffset")]
        public virtual object? EndOffset { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("partOfEpisode")]
        public virtual Episode? PartOfEpisode { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("partOfSeason")]
        public virtual CreativeWorkSeason? PartOfSeason { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("partOfSeries")]
        public virtual CreativeWorkSeries? PartOfSeries { get; set; }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
        [JsonPropertyName("startOffset")]
        public virtual object? StartOffset { get; set; }

    }
}
