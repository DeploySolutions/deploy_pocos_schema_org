using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
    public partial class GeospatialGeometry : Intangible
    {
        public GeospatialGeometry()
        {
            Type = "GeospatialGeometry";
        }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoContains")]
        public virtual object? GeoContains { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoCoveredBy")]
        public virtual object? GeoCoveredBy { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoCovers")]
        public virtual object? GeoCovers { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoCrosses")]
        public virtual object? GeoCrosses { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoDisjoint")]
        public virtual object? GeoDisjoint { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoEquals")]
        public virtual object? GeoEquals { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoIntersects")]
        public virtual object? GeoIntersects { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoOverlaps")]
        public virtual object? GeoOverlaps { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoTouches")]
        public virtual object? GeoTouches { get; set; }

    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// </summary>
        [JsonPropertyName("geoWithin")]
        public virtual object? GeoWithin { get; set; }

    }
}
