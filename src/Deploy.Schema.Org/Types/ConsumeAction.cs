using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
    public partial class ConsumeAction : Action
    {
        public ConsumeAction()
        {
            Type = "ConsumeAction";
        }

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
        [JsonPropertyName("actionAccessibilityRequirement")]
        public virtual ActionAccessSpecification? ActionAccessibilityRequirement { get; set; }

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// </summary>
        [JsonPropertyName("expectsAcceptanceOf")]
        public virtual Offer? ExpectsAcceptanceOf { get; set; }

    }
}
