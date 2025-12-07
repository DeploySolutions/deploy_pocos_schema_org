using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    public partial class PaymentChargeSpecification : PriceSpecification
    {
        public PaymentChargeSpecification()
        {
            Type = "PaymentChargeSpecification";
        }

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
        [JsonPropertyName("appliesToDeliveryMethod")]
        public virtual DeliveryMethod? AppliesToDeliveryMethod { get; set; }

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
        [JsonPropertyName("appliesToPaymentMethod")]
        public virtual PaymentMethod? AppliesToPaymentMethod { get; set; }

    }
}
