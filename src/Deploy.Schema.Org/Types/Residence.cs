using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The place where a person lives.
    /// </summary>
    public partial class Residence : Place
    {
        public Residence()
        {
            Type = "Residence";
        }

    /// <summary>
    /// The place where a person lives.
    /// </summary>
        [JsonPropertyName("accommodationFloorPlan")]
        public virtual FloorPlan? AccommodationFloorPlan { get; set; }

    }
}
