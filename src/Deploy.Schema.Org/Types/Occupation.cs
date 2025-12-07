using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
    public partial class Occupation : Intangible
    {
        public Occupation()
        {
            Type = "Occupation";
        }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("educationRequirements")]
        public virtual object? EducationRequirements { get; set; }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("estimatedSalary")]
        public virtual object? EstimatedSalary { get; set; }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("experienceRequirements")]
        public virtual object? ExperienceRequirements { get; set; }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("occupationalCategory")]
        public virtual object? OccupationalCategory { get; set; }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("occupationLocation")]
        public virtual AdministrativeArea? OccupationLocation { get; set; }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("qualifications")]
        public virtual object? Qualifications { get; set; }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("responsibilities")]
        public virtual string? Responsibilities { get; set; }

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// </summary>
        [JsonPropertyName("skills")]
        public virtual object? Skills { get; set; }

    }
}
