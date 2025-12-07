using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
    public partial class InteractionCounter : StructuredValue
    {
        public InteractionCounter()
        {
            Type = "InteractionCounter";
        }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
        [JsonPropertyName("endTime")]
        public virtual object? EndTime { get; set; }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
        [JsonPropertyName("interactionService")]
        public virtual object? InteractionService { get; set; }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
        [JsonPropertyName("interactionType")]
        public virtual Action? InteractionType { get; set; }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
        [JsonPropertyName("location")]
        public virtual object? Location { get; set; }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
        [JsonPropertyName("startTime")]
        public virtual object? StartTime { get; set; }

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
        [JsonPropertyName("userInteractionCount")]
        public virtual Integer? UserInteractionCount { get; set; }

    }
}
