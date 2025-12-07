using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
    public partial class TVSeries : CreativeWork
    {
        public TVSeries()
        {
            Type = "TVSeries";
        }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("containsSeason")]
        public virtual CreativeWorkSeason? ContainsSeason { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("countryOfOrigin")]
        public virtual Country? CountryOfOrigin { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("episode")]
        public virtual Episode? Episode { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("episodes")]
        public virtual Episode? Episodes { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("numberOfEpisodes")]
        public virtual Integer? NumberOfEpisodes { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("numberOfSeasons")]
        public virtual Integer? NumberOfSeasons { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("productionCompany")]
        public virtual Organization? ProductionCompany { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("season")]
        public virtual object? Season { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("seasons")]
        public virtual CreativeWorkSeason? Seasons { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("titleEIDR")]
        public virtual object? TitleEIDR { get; set; }

    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("trailer")]
        public virtual VideoObject? Trailer { get; set; }

    }
}
