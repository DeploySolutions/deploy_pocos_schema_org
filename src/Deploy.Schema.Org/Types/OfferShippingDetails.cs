using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
    public partial class OfferShippingDetails : StructuredValue
    {
        public OfferShippingDetails()
        {
            Type = "OfferShippingDetails";
        }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("deliveryTime")]
        public virtual ShippingDeliveryTime? DeliveryTime { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("depth")]
        public virtual object? Depth { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("doesNotShip")]
        public virtual bool? DoesNotShip { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("hasShippingService")]
        public virtual ShippingService? HasShippingService { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("height")]
        public virtual object? Height { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("shippingDestination")]
        public virtual DefinedRegion? ShippingDestination { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("shippingLabel")]
        public virtual string? ShippingLabel { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("shippingOrigin")]
        public virtual DefinedRegion? ShippingOrigin { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("shippingRate")]
        public virtual object? ShippingRate { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("shippingSettingsLink")]
        public virtual string? ShippingSettingsLink { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("transitTimeLabel")]
        public virtual string? TransitTimeLabel { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("validForMemberTier")]
        public virtual MemberProgramTier? ValidForMemberTier { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("weight")]
        public virtual object? Weight { get; set; }

    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    /// Two entities that are identical but differ in rate and time:
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// </summary>
        [JsonPropertyName("width")]
        public virtual object? Width { get; set; }

    }
}
