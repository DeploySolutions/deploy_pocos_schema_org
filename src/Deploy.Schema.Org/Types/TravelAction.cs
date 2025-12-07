using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of traveling from a fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
    public partial class TravelAction : MoveAction
    {
        public TravelAction()
        {
            Type = "TravelAction";
        }

    /// <summary>
    /// The act of traveling from a fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// </summary>
        [JsonPropertyName("distance")]
        public virtual Distance? Distance { get; set; }

    }
}
