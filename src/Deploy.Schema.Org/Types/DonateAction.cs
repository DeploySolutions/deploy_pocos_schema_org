using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// </summary>
    public partial class DonateAction : TransferAction
    {
        public DonateAction()
        {
            Type = "DonateAction";
        }

    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// </summary>
        [JsonPropertyName("price")]
        public virtual object? Price { get; set; }

    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// </summary>
        [JsonPropertyName("priceCurrency")]
        public virtual string? PriceCurrency { get; set; }

    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// </summary>
        [JsonPropertyName("priceSpecification")]
        public virtual PriceSpecification? PriceSpecification { get; set; }

    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// </summary>
        [JsonPropertyName("recipient")]
        public virtual object? Recipient { get; set; }

    }
}
