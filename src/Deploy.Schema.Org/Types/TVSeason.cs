using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
    public partial class TVSeason : CreativeWork
    {
        public TVSeason()
        {
            Type = "TVSeason";
        }

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("countryOfOrigin")]
        public virtual Country? CountryOfOrigin { get; set; }

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("partOfTVSeries")]
        public virtual TVSeries? PartOfTVSeries { get; set; }

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
        [JsonPropertyName("titleEIDR")]
        public virtual object? TitleEIDR { get; set; }

    }
}
