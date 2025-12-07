using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    public partial class OrderItem : Intangible
    {
        public OrderItem()
        {
            Type = "OrderItem";
        }

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
        [JsonPropertyName("orderDelivery")]
        public virtual ParcelDelivery? OrderDelivery { get; set; }

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
        [JsonPropertyName("orderedItem")]
        public virtual object? OrderedItem { get; set; }

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
        [JsonPropertyName("orderItemNumber")]
        public virtual string? OrderItemNumber { get; set; }

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
        [JsonPropertyName("orderItemStatus")]
        public virtual OrderStatus? OrderItemStatus { get; set; }

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
        [JsonPropertyName("orderQuantity")]
        public virtual object? OrderQuantity { get; set; }

    }
}
