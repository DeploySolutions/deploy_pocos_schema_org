using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    public partial class BusTrip : Trip
    {
        public BusTrip()
        {
            Type = "BusTrip";
        }

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
        [JsonPropertyName("arrivalBusStop")]
        public virtual object? ArrivalBusStop { get; set; }

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
        [JsonPropertyName("busName")]
        public virtual string? BusName { get; set; }

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
        [JsonPropertyName("busNumber")]
        public virtual string? BusNumber { get; set; }

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
        [JsonPropertyName("departureBusStop")]
        public virtual object? DepartureBusStop { get; set; }

    }
}
