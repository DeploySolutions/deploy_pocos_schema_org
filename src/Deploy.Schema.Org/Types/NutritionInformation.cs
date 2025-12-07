using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
    public partial class NutritionInformation : StructuredValue
    {
        public NutritionInformation()
        {
            Type = "NutritionInformation";
        }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("calories")]
        public virtual Energy? Calories { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("carbohydrateContent")]
        public virtual Mass? CarbohydrateContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("cholesterolContent")]
        public virtual Mass? CholesterolContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("fatContent")]
        public virtual Mass? FatContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("fiberContent")]
        public virtual Mass? FiberContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("proteinContent")]
        public virtual Mass? ProteinContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("saturatedFatContent")]
        public virtual Mass? SaturatedFatContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("servingSize")]
        public virtual string? ServingSize { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("sodiumContent")]
        public virtual Mass? SodiumContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("sugarContent")]
        public virtual Mass? SugarContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("transFatContent")]
        public virtual Mass? TransFatContent { get; set; }

    /// <summary>
    /// Nutritional information about the recipe.
    /// </summary>
        [JsonPropertyName("unsaturatedFatContent")]
        public virtual Mass? UnsaturatedFatContent { get; set; }

    }
}
