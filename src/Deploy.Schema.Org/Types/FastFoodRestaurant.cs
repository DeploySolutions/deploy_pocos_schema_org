using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A fast-food restaurant.
    /// </summary>
    public partial class FastFoodRestaurant : FoodEstablishment
    {
        public FastFoodRestaurant()
        {
            Type = "FastFoodRestaurant";
        }

    }
}
