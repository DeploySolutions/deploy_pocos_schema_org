using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
    public partial class ShippingRateSettings : StructuredValue
    {
        public ShippingRateSettings()
        {
            Type = "ShippingRateSettings";
        }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("doesNotShip")]
        public virtual bool? DoesNotShip { get; set; }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("freeShippingThreshold")]
        public virtual object? FreeShippingThreshold { get; set; }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("isUnlabelledFallback")]
        public virtual bool? IsUnlabelledFallback { get; set; }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("orderPercentage")]
        public virtual double? OrderPercentage { get; set; }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("shippingDestination")]
        public virtual DefinedRegion? ShippingDestination { get; set; }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("shippingLabel")]
        public virtual string? ShippingLabel { get; set; }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("shippingRate")]
        public virtual object? ShippingRate { get; set; }

    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// </summary>
        [JsonPropertyName("weightPercentage")]
        public virtual double? WeightPercentage { get; set; }

    }
}
