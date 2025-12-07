using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    public partial class TrainTrip : Trip
    {
        public TrainTrip()
        {
            Type = "TrainTrip";
        }

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
        [JsonPropertyName("arrivalPlatform")]
        public virtual string? ArrivalPlatform { get; set; }

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
        [JsonPropertyName("arrivalStation")]
        public virtual TrainStation? ArrivalStation { get; set; }

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
        [JsonPropertyName("departurePlatform")]
        public virtual string? DeparturePlatform { get; set; }

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
        [JsonPropertyName("departureStation")]
        public virtual TrainStation? DepartureStation { get; set; }

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
        [JsonPropertyName("trainName")]
        public virtual string? TrainName { get; set; }

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
        [JsonPropertyName("trainNumber")]
        public virtual string? TrainNumber { get; set; }

    }
}
