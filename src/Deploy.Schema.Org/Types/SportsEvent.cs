using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    public partial class SportsEvent : Event
    {
        public SportsEvent()
        {
            Type = "SportsEvent";
        }

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
        [JsonPropertyName("awayTeam")]
        public virtual object? AwayTeam { get; set; }

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
        [JsonPropertyName("competitor")]
        public virtual object? Competitor { get; set; }

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
        [JsonPropertyName("homeTeam")]
        public virtual object? HomeTeam { get; set; }

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
        [JsonPropertyName("referee")]
        public virtual Person? Referee { get; set; }

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
        [JsonPropertyName("sport")]
        public virtual object? Sport { get; set; }

    }
}
