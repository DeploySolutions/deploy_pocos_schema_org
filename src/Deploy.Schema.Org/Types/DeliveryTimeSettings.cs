using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A DeliveryTimeSettings represents re-usable pieces of shipping information, relating to timing. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished (and identified/referenced) by their different values for [[transitTimeLabel]].
    /// </summary>
    public partial class DeliveryTimeSettings : StructuredValue
    {
        public DeliveryTimeSettings()
        {
            Type = "DeliveryTimeSettings";
        }

    /// <summary>
    /// A DeliveryTimeSettings represents re-usable pieces of shipping information, relating to timing. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished (and identified/referenced) by their different values for [[transitTimeLabel]].
    /// </summary>
        [JsonPropertyName("deliveryTime")]
        public virtual ShippingDeliveryTime? DeliveryTime { get; set; }

    /// <summary>
    /// A DeliveryTimeSettings represents re-usable pieces of shipping information, relating to timing. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished (and identified/referenced) by their different values for [[transitTimeLabel]].
    /// </summary>
        [JsonPropertyName("isUnlabelledFallback")]
        public virtual bool? IsUnlabelledFallback { get; set; }

    /// <summary>
    /// A DeliveryTimeSettings represents re-usable pieces of shipping information, relating to timing. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished (and identified/referenced) by their different values for [[transitTimeLabel]].
    /// </summary>
        [JsonPropertyName("shippingDestination")]
        public virtual DefinedRegion? ShippingDestination { get; set; }

    /// <summary>
    /// A DeliveryTimeSettings represents re-usable pieces of shipping information, relating to timing. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished (and identified/referenced) by their different values for [[transitTimeLabel]].
    /// </summary>
        [JsonPropertyName("transitTimeLabel")]
        public virtual string? TransitTimeLabel { get; set; }

    }
}
