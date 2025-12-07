using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
    public partial class CreativeWorkSeason : CreativeWork
    {
        public CreativeWorkSeason()
        {
            Type = "CreativeWorkSeason";
        }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("endDate")]
        public virtual object? EndDate { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("episode")]
        public virtual Episode? Episode { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("episodes")]
        public virtual Episode? Episodes { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("numberOfEpisodes")]
        public virtual Integer? NumberOfEpisodes { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("partOfSeries")]
        public virtual CreativeWorkSeries? PartOfSeries { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("productionCompany")]
        public virtual Organization? ProductionCompany { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("seasonNumber")]
        public virtual object? SeasonNumber { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("startDate")]
        public virtual object? StartDate { get; set; }

    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
        [JsonPropertyName("trailer")]
        public virtual VideoObject? Trailer { get; set; }

    }
}
