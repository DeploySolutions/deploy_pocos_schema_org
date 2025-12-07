using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    public partial class OrderAction : TradeAction
    {
        public OrderAction()
        {
            Type = "OrderAction";
        }

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
        [JsonPropertyName("deliveryMethod")]
        public virtual DeliveryMethod? DeliveryMethod { get; set; }

    }
}
