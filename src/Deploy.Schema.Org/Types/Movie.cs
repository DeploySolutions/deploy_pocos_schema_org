using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A movie.
    /// </summary>
    public partial class Movie : CreativeWork
    {
        public Movie()
        {
            Type = "Movie";
        }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("countryOfOrigin")]
        public virtual Country? CountryOfOrigin { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("productionCompany")]
        public virtual Organization? ProductionCompany { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("subtitleLanguage")]
        public virtual object? SubtitleLanguage { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("titleEIDR")]
        public virtual object? TitleEIDR { get; set; }

    /// <summary>
    /// A movie.
    /// </summary>
        [JsonPropertyName("trailer")]
        public virtual VideoObject? Trailer { get; set; }

    }
}
