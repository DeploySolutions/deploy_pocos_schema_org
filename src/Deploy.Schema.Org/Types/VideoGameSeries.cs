using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A video game series.
    /// </summary>
    public partial class VideoGameSeries : CreativeWorkSeries
    {
        public VideoGameSeries()
        {
            Type = "VideoGameSeries";
        }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("characterAttribute")]
        public virtual Thing? CharacterAttribute { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("cheatCode")]
        public virtual CreativeWork? CheatCode { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("containsSeason")]
        public virtual CreativeWorkSeason? ContainsSeason { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("episode")]
        public virtual Episode? Episode { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("episodes")]
        public virtual Episode? Episodes { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("gameItem")]
        public virtual Thing? GameItem { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("gameLocation")]
        public virtual object? GameLocation { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("gamePlatform")]
        public virtual object? GamePlatform { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("numberOfEpisodes")]
        public virtual Integer? NumberOfEpisodes { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("numberOfPlayers")]
        public virtual QuantitativeValue? NumberOfPlayers { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("numberOfSeasons")]
        public virtual Integer? NumberOfSeasons { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("playMode")]
        public virtual GamePlayMode? PlayMode { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("productionCompany")]
        public virtual Organization? ProductionCompany { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("quest")]
        public virtual Thing? Quest { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("season")]
        public virtual object? Season { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("seasons")]
        public virtual CreativeWorkSeason? Seasons { get; set; }

    /// <summary>
    /// A video game series.
    /// </summary>
        [JsonPropertyName("trailer")]
        public virtual VideoObject? Trailer { get; set; }

    }
}
