using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    public partial class HowTo : CreativeWork
    {
        public HowTo()
        {
            Type = "HowTo";
        }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("estimatedCost")]
        public virtual object? EstimatedCost { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("performTime")]
        public virtual Duration? PerformTime { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("prepTime")]
        public virtual Duration? PrepTime { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("step")]
        public virtual object? Step { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("steps")]
        public virtual object? Steps { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("supply")]
        public virtual object? Supply { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("tool")]
        public virtual object? Tool { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("totalTime")]
        public virtual Duration? TotalTime { get; set; }

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
        [JsonPropertyName("yield")]
        public virtual object? Yield { get; set; }

    }
}
