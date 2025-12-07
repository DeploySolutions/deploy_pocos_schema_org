using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Education event.
    /// </summary>
    public partial class EducationEvent : Event
    {
        public EducationEvent()
        {
            Type = "EducationEvent";
        }

    /// <summary>
    /// Event type: Education event.
    /// </summary>
        [JsonPropertyName("assesses")]
        public virtual object? Assesses { get; set; }

    /// <summary>
    /// Event type: Education event.
    /// </summary>
        [JsonPropertyName("educationalLevel")]
        public virtual object? EducationalLevel { get; set; }

    /// <summary>
    /// Event type: Education event.
    /// </summary>
        [JsonPropertyName("teaches")]
        public virtual object? Teaches { get; set; }

    }
}
