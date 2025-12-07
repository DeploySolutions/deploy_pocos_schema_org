using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
    public partial class Recipe : HowTo
    {
        public Recipe()
        {
            Type = "Recipe";
        }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("cookingMethod")]
        public virtual string? CookingMethod { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("cookTime")]
        public virtual Duration? CookTime { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("ingredients")]
        public virtual string? Ingredients { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("nutrition")]
        public virtual NutritionInformation? Nutrition { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("recipeCategory")]
        public virtual string? RecipeCategory { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("recipeCuisine")]
        public virtual string? RecipeCuisine { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("recipeIngredient")]
        public virtual string? RecipeIngredient { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("recipeInstructions")]
        public virtual object? RecipeInstructions { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("recipeYield")]
        public virtual object? RecipeYield { get; set; }

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// </summary>
        [JsonPropertyName("suitableForDiet")]
        public virtual RestrictedDiet? SuitableForDiet { get; set; }

    }
}
