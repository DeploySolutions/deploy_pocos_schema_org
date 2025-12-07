using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    public partial class Airline : Organization
    {
        public Airline()
        {
            Type = "Airline";
        }

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
        [JsonPropertyName("boardingPolicy")]
        public virtual BoardingPolicyType? BoardingPolicy { get; set; }

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
        [JsonPropertyName("iataCode")]
        public virtual string? IataCode { get; set; }

    }
}
