using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    public partial class PeopleAudience : Audience
    {
        public PeopleAudience()
        {
            Type = "PeopleAudience";
        }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("healthCondition")]
        public virtual MedicalCondition? HealthCondition { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("requiredGender")]
        public virtual string? RequiredGender { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("requiredMaxAge")]
        public virtual Integer? RequiredMaxAge { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("requiredMinAge")]
        public virtual Integer? RequiredMinAge { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("suggestedAge")]
        public virtual QuantitativeValue? SuggestedAge { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("suggestedGender")]
        public virtual object? SuggestedGender { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("suggestedMaxAge")]
        public virtual double? SuggestedMaxAge { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("suggestedMeasurement")]
        public virtual QuantitativeValue? SuggestedMeasurement { get; set; }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
        [JsonPropertyName("suggestedMinAge")]
        public virtual double? SuggestedMinAge { get; set; }

    }
}
