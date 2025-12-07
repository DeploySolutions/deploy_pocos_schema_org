using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A tire shop.
    /// </summary>
    public partial class TireShop : Store
    {
        public TireShop()
        {
            Type = "TireShop";
        }

    }
}
