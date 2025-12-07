using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An airline flight.
    /// </summary>
    public partial class Flight : Trip
    {
        public Flight()
        {
            Type = "Flight";
        }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("aircraft")]
        public virtual object? Aircraft { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("arrivalAirport")]
        public virtual Airport? ArrivalAirport { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("arrivalGate")]
        public virtual string? ArrivalGate { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("arrivalTerminal")]
        public virtual string? ArrivalTerminal { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("boardingPolicy")]
        public virtual BoardingPolicyType? BoardingPolicy { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("carrier")]
        public virtual Organization? Carrier { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("departureAirport")]
        public virtual Airport? DepartureAirport { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("departureGate")]
        public virtual string? DepartureGate { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("departureTerminal")]
        public virtual string? DepartureTerminal { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("estimatedFlightDuration")]
        public virtual object? EstimatedFlightDuration { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("flightDistance")]
        public virtual object? FlightDistance { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("flightNumber")]
        public virtual string? FlightNumber { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("mealService")]
        public virtual string? MealService { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("seller")]
        public virtual object? Seller { get; set; }

    /// <summary>
    /// An airline flight.
    /// </summary>
        [JsonPropertyName("webCheckinTime")]
        public virtual DateTime? WebCheckinTime { get; set; }

    }
}
