using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// </summary>
    public partial class PerformanceRole : Role
    {
        public PerformanceRole()
        {
            Type = "PerformanceRole";
        }

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// </summary>
        [JsonPropertyName("characterName")]
        public virtual string? CharacterName { get; set; }

    }
}
