using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
    public partial class GeoShape : StructuredValue
    {
        public GeoShape()
        {
            Type = "GeoShape";
        }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("address")]
        public virtual object? Address { get; set; }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("addressCountry")]
        public virtual object? AddressCountry { get; set; }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("box")]
        public virtual string? Box { get; set; }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("circle")]
        public virtual string? Circle { get; set; }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("elevation")]
        public virtual object? Elevation { get; set; }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("line")]
        public virtual string? Line { get; set; }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("polygon")]
        public virtual string? Polygon { get; set; }

    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// </summary>
        [JsonPropertyName("postalCode")]
        public virtual string? PostalCode { get; set; }

    }
}
