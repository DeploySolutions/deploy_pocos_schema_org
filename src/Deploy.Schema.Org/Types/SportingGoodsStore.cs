using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A sporting goods store.
    /// </summary>
    public partial class SportingGoodsStore : Store
    {
        public SportingGoodsStore()
        {
            Type = "SportingGoodsStore";
        }

    }
}
