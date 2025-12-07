using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Indicates employment-related experience requirements, e.g. [[monthsOfExperience]].
    /// </summary>
    public partial class OccupationalExperienceRequirements : Intangible
    {
        public OccupationalExperienceRequirements()
        {
            Type = "OccupationalExperienceRequirements";
        }

    /// <summary>
    /// Indicates employment-related experience requirements, e.g. [[monthsOfExperience]].
    /// </summary>
        [JsonPropertyName("monthsOfExperience")]
        public virtual double? MonthsOfExperience { get; set; }

    }
}
