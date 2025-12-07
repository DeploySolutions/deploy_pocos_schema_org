using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An educational organization.
    /// </summary>
    public partial class EducationalOrganization : Organization
    {
        public EducationalOrganization()
        {
            Type = "EducationalOrganization";
        }

    /// <summary>
    /// An educational organization.
    /// </summary>
        [JsonPropertyName("alumni")]
        public virtual Person? Alumni { get; set; }

    }
}
