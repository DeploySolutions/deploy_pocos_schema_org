using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
    public partial class CookAction : CreateAction
    {
        public CookAction()
        {
            Type = "CookAction";
        }

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
        [JsonPropertyName("foodEstablishment")]
        public virtual object? FoodEstablishment { get; set; }

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
        [JsonPropertyName("foodEvent")]
        public virtual FoodEvent? FoodEvent { get; set; }

    /// <summary>
    /// The act of producing/preparing food.
    /// </summary>
        [JsonPropertyName("recipe")]
        public virtual Recipe? Recipe { get; set; }

    }
}
