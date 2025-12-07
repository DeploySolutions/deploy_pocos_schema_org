using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
    public partial class PriceSpecification : StructuredValue
    {
        public PriceSpecification()
        {
            Type = "PriceSpecification";
        }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("eligibleQuantity")]
        public virtual QuantitativeValue? EligibleQuantity { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("eligibleTransactionVolume")]
        public virtual PriceSpecification? EligibleTransactionVolume { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("maxPrice")]
        public virtual double? MaxPrice { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("membershipPointsEarned")]
        public virtual object? MembershipPointsEarned { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("minPrice")]
        public virtual double? MinPrice { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("price")]
        public virtual object? Price { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("priceCurrency")]
        public virtual string? PriceCurrency { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("validForMemberTier")]
        public virtual MemberProgramTier? ValidForMemberTier { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("validFrom")]
        public virtual object? ValidFrom { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("validThrough")]
        public virtual object? ValidThrough { get; set; }

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// </summary>
        [JsonPropertyName("valueAddedTaxIncluded")]
        public virtual bool? ValueAddedTaxIncluded { get; set; }

    }
}
