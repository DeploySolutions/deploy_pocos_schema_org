using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
    public partial class Demand : Intangible
    {
        public Demand()
        {
            Type = "Demand";
        }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("acceptedPaymentMethod")]
        public virtual object? AcceptedPaymentMethod { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("advanceBookingRequirement")]
        public virtual QuantitativeValue? AdvanceBookingRequirement { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("areaServed")]
        public virtual object? AreaServed { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("asin")]
        public virtual object? Asin { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("availability")]
        public virtual ItemAvailability? Availability { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("availabilityEnds")]
        public virtual object? AvailabilityEnds { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("availabilityStarts")]
        public virtual object? AvailabilityStarts { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("availableAtOrFrom")]
        public virtual Place? AvailableAtOrFrom { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("availableDeliveryMethod")]
        public virtual DeliveryMethod? AvailableDeliveryMethod { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("businessFunction")]
        public virtual BusinessFunction? BusinessFunction { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("deliveryLeadTime")]
        public virtual QuantitativeValue? DeliveryLeadTime { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("eligibleCustomerType")]
        public virtual BusinessEntityType? EligibleCustomerType { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("eligibleDuration")]
        public virtual QuantitativeValue? EligibleDuration { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("eligibleQuantity")]
        public virtual QuantitativeValue? EligibleQuantity { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("eligibleRegion")]
        public virtual object? EligibleRegion { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("eligibleTransactionVolume")]
        public virtual PriceSpecification? EligibleTransactionVolume { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("gtin")]
        public virtual object? Gtin { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("gtin12")]
        public virtual string? Gtin12 { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("gtin13")]
        public virtual string? Gtin13 { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("gtin14")]
        public virtual string? Gtin14 { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("gtin8")]
        public virtual string? Gtin8 { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("includesObject")]
        public virtual TypeAndQuantityNode? IncludesObject { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("ineligibleRegion")]
        public virtual object? IneligibleRegion { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("inventoryLevel")]
        public virtual QuantitativeValue? InventoryLevel { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("itemCondition")]
        public virtual OfferItemCondition? ItemCondition { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("itemOffered")]
        public virtual object? ItemOffered { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("mpn")]
        public virtual string? Mpn { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("priceSpecification")]
        public virtual PriceSpecification? PriceSpecification { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("seller")]
        public virtual object? Seller { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("serialNumber")]
        public virtual string? SerialNumber { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("sku")]
        public virtual string? Sku { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("validFrom")]
        public virtual object? ValidFrom { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("validThrough")]
        public virtual object? ValidThrough { get; set; }

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// </summary>
        [JsonPropertyName("warranty")]
        public virtual WarrantyPromise? Warranty { get; set; }

    }
}
