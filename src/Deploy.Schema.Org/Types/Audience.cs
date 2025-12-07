using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
    public partial class Audience : Intangible
    {
        public Audience()
        {
            Type = "Audience";
        }

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
        [JsonPropertyName("audienceType")]
        public virtual string? AudienceType { get; set; }

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
        [JsonPropertyName("geographicArea")]
        public virtual AdministrativeArea? GeographicArea { get; set; }

    }
}
