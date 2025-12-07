using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
    public partial class LocationFeatureSpecification : PropertyValue
    {
        public LocationFeatureSpecification()
        {
            Type = "LocationFeatureSpecification";
        }

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
        [JsonPropertyName("hoursAvailable")]
        public virtual OpeningHoursSpecification? HoursAvailable { get; set; }

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
        [JsonPropertyName("validFrom")]
        public virtual object? ValidFrom { get; set; }

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
        [JsonPropertyName("validThrough")]
        public virtual object? ValidThrough { get; set; }

    }
}
