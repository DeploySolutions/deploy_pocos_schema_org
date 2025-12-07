using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
    public partial class Menu : CreativeWork
    {
        public Menu()
        {
            Type = "Menu";
        }

    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
        [JsonPropertyName("hasMenuItem")]
        public virtual MenuItem? HasMenuItem { get; set; }

    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
        [JsonPropertyName("hasMenuSection")]
        public virtual MenuSection? HasMenuSection { get; set; }

    }
}
