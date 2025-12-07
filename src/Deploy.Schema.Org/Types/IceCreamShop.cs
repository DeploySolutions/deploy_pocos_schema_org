using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An ice cream shop.
    /// </summary>
    public partial class IceCreamShop : FoodEstablishment
    {
        public IceCreamShop()
        {
            Type = "IceCreamShop";
        }

    }
}
