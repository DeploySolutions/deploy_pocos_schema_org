using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury buses, usually in service for long distance travel.
    /// </summary>
    public partial class BusOrCoach : Vehicle
    {
        public BusOrCoach()
        {
            Type = "BusOrCoach";
        }

    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury buses, usually in service for long distance travel.
    /// </summary>
        [JsonPropertyName("acrissCode")]
        public virtual string? AcrissCode { get; set; }

    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury buses, usually in service for long distance travel.
    /// </summary>
        [JsonPropertyName("roofLoad")]
        public virtual QuantitativeValue? RoofLoad { get; set; }

    }
}
