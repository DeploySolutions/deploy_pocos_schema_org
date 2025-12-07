using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An instance of a [[Course]] which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
    public partial class CourseInstance : Event
    {
        public CourseInstance()
        {
            Type = "CourseInstance";
        }

    /// <summary>
    /// An instance of a [[Course]] which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
        [JsonPropertyName("courseMode")]
        public virtual object? CourseMode { get; set; }

    /// <summary>
    /// An instance of a [[Course]] which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
        [JsonPropertyName("courseSchedule")]
        public virtual Schedule? CourseSchedule { get; set; }

    /// <summary>
    /// An instance of a [[Course]] which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
        [JsonPropertyName("courseWorkload")]
        public virtual string? CourseWorkload { get; set; }

    /// <summary>
    /// An instance of a [[Course]] which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// </summary>
        [JsonPropertyName("instructor")]
        public virtual Person? Instructor { get; set; }

    }
}
