using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    ///        
    /// </summary>
    public partial class GeoCircle : GeoShape
    {
        public GeoCircle()
        {
            Type = "GeoCircle";
        }

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    ///        
    /// </summary>
        [JsonPropertyName("geoMidpoint")]
        public virtual GeoCoordinates? GeoMidpoint { get; set; }

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    ///        
    /// </summary>
        [JsonPropertyName("geoRadius")]
        public virtual object? GeoRadius { get; set; }

    }
}
