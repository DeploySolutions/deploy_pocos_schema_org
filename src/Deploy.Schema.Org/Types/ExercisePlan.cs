using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    public partial class ExercisePlan : CreativeWork
    {
        public ExercisePlan()
        {
            Type = "ExercisePlan";
        }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("activityDuration")]
        public virtual object? ActivityDuration { get; set; }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("activityFrequency")]
        public virtual object? ActivityFrequency { get; set; }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("additionalVariable")]
        public virtual string? AdditionalVariable { get; set; }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("exerciseType")]
        public virtual string? ExerciseType { get; set; }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("intensity")]
        public virtual object? Intensity { get; set; }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("repetitions")]
        public virtual object? Repetitions { get; set; }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("restPeriods")]
        public virtual object? RestPeriods { get; set; }

    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
        [JsonPropertyName("workload")]
        public virtual object? Workload { get; set; }

    }
}
