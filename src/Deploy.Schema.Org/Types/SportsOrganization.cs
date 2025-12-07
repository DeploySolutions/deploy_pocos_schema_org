using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    public partial class SportsOrganization : Organization
    {
        public SportsOrganization()
        {
            Type = "SportsOrganization";
        }

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
        [JsonPropertyName("sport")]
        public virtual object? Sport { get; set; }

    }
}
