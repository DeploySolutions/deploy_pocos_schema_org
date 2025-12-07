using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    public partial class SomeProducts : Product
    {
        public SomeProducts()
        {
            Type = "SomeProducts";
        }

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
        [JsonPropertyName("inventoryLevel")]
        public virtual QuantitativeValue? InventoryLevel { get; set; }

    }
}
