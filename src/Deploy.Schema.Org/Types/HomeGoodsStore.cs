using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A home goods store.
    /// </summary>
    public partial class HomeGoodsStore : Store
    {
        public HomeGoodsStore()
        {
            Type = "HomeGoodsStore";
        }

    }
}
