using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
    public partial class GeoCoordinates : StructuredValue
    {
        public GeoCoordinates()
        {
            Type = "GeoCoordinates";
        }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
        [JsonPropertyName("address")]
        public virtual object? Address { get; set; }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
        [JsonPropertyName("addressCountry")]
        public virtual object? AddressCountry { get; set; }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
        [JsonPropertyName("elevation")]
        public virtual object? Elevation { get; set; }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
        [JsonPropertyName("latitude")]
        public virtual object? Latitude { get; set; }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
        [JsonPropertyName("longitude")]
        public virtual object? Longitude { get; set; }

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// </summary>
        [JsonPropertyName("postalCode")]
        public virtual string? PostalCode { get; set; }

    }
}
