using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    public partial class EducationalAudience : Audience
    {
        public EducationalAudience()
        {
            Type = "EducationalAudience";
        }

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
        [JsonPropertyName("educationalRole")]
        public virtual string? EducationalRole { get; set; }

    }
}
