using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A public structure, such as a town hall or concert hall.
    /// </summary>
    public partial class CivicStructure : Place
    {
        public CivicStructure()
        {
            Type = "CivicStructure";
        }

    /// <summary>
    /// A public structure, such as a town hall or concert hall.
    /// </summary>
        [JsonPropertyName("openingHours")]
        public virtual string? OpeningHours { get; set; }

    }
}
