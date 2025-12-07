using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
    public partial class Episode : CreativeWork
    {
        public Episode()
        {
            Type = "Episode";
        }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("episodeNumber")]
        public virtual object? EpisodeNumber { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("partOfSeason")]
        public virtual CreativeWorkSeason? PartOfSeason { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("partOfSeries")]
        public virtual CreativeWorkSeries? PartOfSeries { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("productionCompany")]
        public virtual Organization? ProductionCompany { get; set; }

    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("trailer")]
        public virtual VideoObject? Trailer { get; set; }

    }
}
