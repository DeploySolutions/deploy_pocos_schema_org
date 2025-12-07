using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
    public partial class HowToDirection : ListItem
    {
        public HowToDirection()
        {
            Type = "HowToDirection";
        }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("afterMedia")]
        public virtual object? AfterMedia { get; set; }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("beforeMedia")]
        public virtual object? BeforeMedia { get; set; }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("duringMedia")]
        public virtual object? DuringMedia { get; set; }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("performTime")]
        public virtual Duration? PerformTime { get; set; }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("prepTime")]
        public virtual Duration? PrepTime { get; set; }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("supply")]
        public virtual object? Supply { get; set; }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("tool")]
        public virtual object? Tool { get; set; }

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("totalTime")]
        public virtual Duration? TotalTime { get; set; }

    }
}
