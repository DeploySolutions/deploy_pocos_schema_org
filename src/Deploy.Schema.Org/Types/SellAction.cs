using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// </summary>
    public partial class SellAction : TradeAction
    {
        public SellAction()
        {
            Type = "SellAction";
        }

    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// </summary>
        [JsonPropertyName("buyer")]
        public virtual object? Buyer { get; set; }

    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// </summary>
        [JsonPropertyName("warrantyPromise")]
        public virtual WarrantyPromise? WarrantyPromise { get; set; }

    }
}
