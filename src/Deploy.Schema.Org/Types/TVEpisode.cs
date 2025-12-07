using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
    public partial class TVEpisode : Episode
    {
        public TVEpisode()
        {
            Type = "TVEpisode";
        }

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("countryOfOrigin")]
        public virtual Country? CountryOfOrigin { get; set; }

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("partOfTVSeries")]
        public virtual TVSeries? PartOfTVSeries { get; set; }

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("subtitleLanguage")]
        public virtual object? SubtitleLanguage { get; set; }

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
        [JsonPropertyName("titleEIDR")]
        public virtual object? TitleEIDR { get; set; }

    }
}
