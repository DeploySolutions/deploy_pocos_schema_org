using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    public partial class MenuItem : Intangible
    {
        public MenuItem()
        {
            Type = "MenuItem";
        }

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
        [JsonPropertyName("menuAddOn")]
        public virtual object? MenuAddOn { get; set; }

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
        [JsonPropertyName("nutrition")]
        public virtual NutritionInformation? Nutrition { get; set; }

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
        [JsonPropertyName("offers")]
        public virtual object? Offers { get; set; }

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
        [JsonPropertyName("suitableForDiet")]
        public virtual RestrictedDiet? SuitableForDiet { get; set; }

    }
}
