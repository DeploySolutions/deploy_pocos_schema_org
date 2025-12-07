using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// </summary>
    public partial class TradeAction : Action
    {
        public TradeAction()
        {
            Type = "TradeAction";
        }

    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// </summary>
        [JsonPropertyName("price")]
        public virtual object? Price { get; set; }

    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// </summary>
        [JsonPropertyName("priceCurrency")]
        public virtual string? PriceCurrency { get; set; }

    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// </summary>
        [JsonPropertyName("priceSpecification")]
        public virtual PriceSpecification? PriceSpecification { get; set; }

    }
}
