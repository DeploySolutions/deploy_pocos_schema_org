using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
    public partial class MovieSeries : CreativeWorkSeries
    {
        public MovieSeries()
        {
            Type = "MovieSeries";
        }

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
        [JsonPropertyName("actors")]
        public virtual Person? Actors { get; set; }

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
        [JsonPropertyName("director")]
        public virtual Person? Director { get; set; }

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
        [JsonPropertyName("directors")]
        public virtual Person? Directors { get; set; }

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
        [JsonPropertyName("musicBy")]
        public virtual object? MusicBy { get; set; }

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
        [JsonPropertyName("productionCompany")]
        public virtual Organization? ProductionCompany { get; set; }

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// </summary>
        [JsonPropertyName("trailer")]
        public virtual VideoObject? Trailer { get; set; }

    }
}
