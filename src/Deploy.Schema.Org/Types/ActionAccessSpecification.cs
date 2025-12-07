using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
    public partial class ActionAccessSpecification : Intangible
    {
        public ActionAccessSpecification()
        {
            Type = "ActionAccessSpecification";
        }

    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
        [JsonPropertyName("availabilityEnds")]
        public virtual object? AvailabilityEnds { get; set; }

    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
        [JsonPropertyName("availabilityStarts")]
        public virtual object? AvailabilityStarts { get; set; }

    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
        [JsonPropertyName("category")]
        public virtual object? Category { get; set; }

    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
        [JsonPropertyName("eligibleRegion")]
        public virtual object? EligibleRegion { get; set; }

    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
        [JsonPropertyName("expectsAcceptanceOf")]
        public virtual Offer? ExpectsAcceptanceOf { get; set; }

    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
        [JsonPropertyName("ineligibleRegion")]
        public virtual object? IneligibleRegion { get; set; }

    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// </summary>
        [JsonPropertyName("requiresSubscription")]
        public virtual object? RequiresSubscription { get; set; }

    }
}
