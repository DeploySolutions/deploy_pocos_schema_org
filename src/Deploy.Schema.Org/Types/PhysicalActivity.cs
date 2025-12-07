using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
    public partial class PhysicalActivity : LifestyleModification
    {
        public PhysicalActivity()
        {
            Type = "PhysicalActivity";
        }

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
        [JsonPropertyName("associatedAnatomy")]
        public virtual object? AssociatedAnatomy { get; set; }

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
        [JsonPropertyName("category")]
        public virtual object? Category { get; set; }

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
        [JsonPropertyName("epidemiology")]
        public virtual string? Epidemiology { get; set; }

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
        [JsonPropertyName("pathophysiology")]
        public virtual string? Pathophysiology { get; set; }

    }
}
