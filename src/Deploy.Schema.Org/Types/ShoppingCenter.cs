using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A shopping center or mall.
    /// </summary>
    public partial class ShoppingCenter : LocalBusiness
    {
        public ShoppingCenter()
        {
            Type = "ShoppingCenter";
        }

    }
}
