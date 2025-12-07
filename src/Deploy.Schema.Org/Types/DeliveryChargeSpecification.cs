using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    public partial class DeliveryChargeSpecification : PriceSpecification
    {
        public DeliveryChargeSpecification()
        {
            Type = "DeliveryChargeSpecification";
        }

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
        [JsonPropertyName("appliesToDeliveryMethod")]
        public virtual DeliveryMethod? AppliesToDeliveryMethod { get; set; }

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
        [JsonPropertyName("areaServed")]
        public virtual object? AreaServed { get; set; }

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
        [JsonPropertyName("eligibleRegion")]
        public virtual object? EligibleRegion { get; set; }

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
        [JsonPropertyName("ineligibleRegion")]
        public virtual object? IneligibleRegion { get; set; }

    }
}
