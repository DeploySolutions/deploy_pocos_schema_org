using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of playing a video game.
    /// </summary>
    public partial class PlayGameAction : ConsumeAction
    {
        public PlayGameAction()
        {
            Type = "PlayGameAction";
        }

    /// <summary>
    /// The act of playing a video game.
    /// </summary>
        [JsonPropertyName("gameAvailabilityType")]
        public virtual object? GameAvailabilityType { get; set; }

    }
}
