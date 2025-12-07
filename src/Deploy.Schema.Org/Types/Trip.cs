using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
    public partial class Trip : Intangible
    {
        public Trip()
        {
            Type = "Trip";
        }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("arrivalTime")]
        public virtual object? ArrivalTime { get; set; }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("departureTime")]
        public virtual object? DepartureTime { get; set; }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("itinerary")]
        public virtual object? Itinerary { get; set; }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("offers")]
        public virtual object? Offers { get; set; }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("partOfTrip")]
        public virtual Trip? PartOfTrip { get; set; }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("subTrip")]
        public virtual Trip? SubTrip { get; set; }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
        [JsonPropertyName("tripOrigin")]
        public virtual Place? TripOrigin { get; set; }

    }
}
