using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A trip on a commercial ferry line.
    /// </summary>
    public partial class BoatTrip : Trip
    {
        public BoatTrip()
        {
            Type = "BoatTrip";
        }

    /// <summary>
    /// A trip on a commercial ferry line.
    /// </summary>
        [JsonPropertyName("arrivalBoatTerminal")]
        public virtual BoatTerminal? ArrivalBoatTerminal { get; set; }

    /// <summary>
    /// A trip on a commercial ferry line.
    /// </summary>
        [JsonPropertyName("departureBoatTerminal")]
        public virtual BoatTerminal? DepartureBoatTerminal { get; set; }

    }
}
