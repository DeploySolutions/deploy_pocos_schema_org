using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// </summary>
    public partial class BuyAction : TradeAction
    {
        public BuyAction()
        {
            Type = "BuyAction";
        }

    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// </summary>
        [JsonPropertyName("seller")]
        public virtual object? Seller { get; set; }

    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// </summary>
        [JsonPropertyName("vendor")]
        public virtual object? Vendor { get; set; }

    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// </summary>
        [JsonPropertyName("warrantyPromise")]
        public virtual WarrantyPromise? WarrantyPromise { get; set; }

    }
}
