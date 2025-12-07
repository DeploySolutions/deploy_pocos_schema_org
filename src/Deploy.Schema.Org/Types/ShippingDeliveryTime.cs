using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// ShippingDeliveryTime provides various pieces of information about delivery times for shipping.
    /// </summary>
    public partial class ShippingDeliveryTime : StructuredValue
    {
        public ShippingDeliveryTime()
        {
            Type = "ShippingDeliveryTime";
        }

    /// <summary>
    /// ShippingDeliveryTime provides various pieces of information about delivery times for shipping.
    /// </summary>
        [JsonPropertyName("businessDays")]
        public virtual object? BusinessDays { get; set; }

    /// <summary>
    /// ShippingDeliveryTime provides various pieces of information about delivery times for shipping.
    /// </summary>
        [JsonPropertyName("cutoffTime")]
        public virtual TimeSpan? CutoffTime { get; set; }

    /// <summary>
    /// ShippingDeliveryTime provides various pieces of information about delivery times for shipping.
    /// </summary>
        [JsonPropertyName("handlingTime")]
        public virtual object? HandlingTime { get; set; }

    /// <summary>
    /// ShippingDeliveryTime provides various pieces of information about delivery times for shipping.
    /// </summary>
        [JsonPropertyName("transitTime")]
        public virtual object? TransitTime { get; set; }

    }
}
