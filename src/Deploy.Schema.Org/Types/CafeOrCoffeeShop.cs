using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A cafe or coffee shop.
    /// </summary>
    public partial class CafeOrCoffeeShop : FoodEstablishment
    {
        public CafeOrCoffeeShop()
        {
            Type = "CafeOrCoffeeShop";
        }

    }
}
