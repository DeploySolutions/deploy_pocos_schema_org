using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    public partial class SportsTeam : SportsOrganization
    {
        public SportsTeam()
        {
            Type = "SportsTeam";
        }

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
        [JsonPropertyName("athlete")]
        public virtual Person? Athlete { get; set; }

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
        [JsonPropertyName("coach")]
        public virtual Person? Coach { get; set; }

    /// <summary>
    /// Organization: Sports team.
    /// </summary>
        [JsonPropertyName("gender")]
        public virtual object? Gender { get; set; }

    }
}
