using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
    public partial class DeliveryEvent : Event
    {
        public DeliveryEvent()
        {
            Type = "DeliveryEvent";
        }

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
        [JsonPropertyName("accessCode")]
        public virtual string? AccessCode { get; set; }

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
        [JsonPropertyName("availableFrom")]
        public virtual DateTime? AvailableFrom { get; set; }

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
        [JsonPropertyName("availableThrough")]
        public virtual DateTime? AvailableThrough { get; set; }

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
        [JsonPropertyName("hasDeliveryMethod")]
        public virtual DeliveryMethod? HasDeliveryMethod { get; set; }

    }
}
