using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Residence type: Single-family home.
    /// </summary>
    public partial class SingleFamilyResidence : House
    {
        public SingleFamilyResidence()
        {
            Type = "SingleFamilyResidence";
        }

    /// <summary>
    /// Residence type: Single-family home.
    /// </summary>
        [JsonPropertyName("numberOfRooms")]
        public virtual object? NumberOfRooms { get; set; }

    /// <summary>
    /// Residence type: Single-family home.
    /// </summary>
        [JsonPropertyName("occupancy")]
        public virtual QuantitativeValue? Occupancy { get; set; }

    }
}
