using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// </summary>
    public partial class MenuSection : CreativeWork
    {
        public MenuSection()
        {
            Type = "MenuSection";
        }

    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// </summary>
        [JsonPropertyName("hasMenuItem")]
        public virtual MenuItem? HasMenuItem { get; set; }

    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// </summary>
        [JsonPropertyName("hasMenuSection")]
        public virtual MenuSection? HasMenuSection { get; set; }

    }
}
