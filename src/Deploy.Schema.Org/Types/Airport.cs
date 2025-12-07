using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An airport.
    /// </summary>
    public partial class Airport : CivicStructure
    {
        public Airport()
        {
            Type = "Airport";
        }

    /// <summary>
    /// An airport.
    /// </summary>
        [JsonPropertyName("iataCode")]
        public virtual string? IataCode { get; set; }

    /// <summary>
    /// An airport.
    /// </summary>
        [JsonPropertyName("icaoCode")]
        public virtual string? IcaoCode { get; set; }

    }
}
