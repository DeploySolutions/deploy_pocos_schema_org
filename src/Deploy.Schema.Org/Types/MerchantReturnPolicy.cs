using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
    public partial class MerchantReturnPolicy : Intangible
    {
        public MerchantReturnPolicy()
        {
            Type = "MerchantReturnPolicy";
        }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("additionalProperty")]
        public virtual PropertyValue? AdditionalProperty { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("applicableCountry")]
        public virtual object? ApplicableCountry { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("customerRemorseReturnFees")]
        public virtual ReturnFeesEnumeration? CustomerRemorseReturnFees { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("customerRemorseReturnLabelSource")]
        public virtual ReturnLabelSourceEnumeration? CustomerRemorseReturnLabelSource { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("customerRemorseReturnShippingFeesAmount")]
        public virtual MonetaryAmount? CustomerRemorseReturnShippingFeesAmount { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("inStoreReturnsOffered")]
        public virtual bool? InStoreReturnsOffered { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("itemCondition")]
        public virtual OfferItemCondition? ItemCondition { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("itemDefectReturnFees")]
        public virtual ReturnFeesEnumeration? ItemDefectReturnFees { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("itemDefectReturnLabelSource")]
        public virtual ReturnLabelSourceEnumeration? ItemDefectReturnLabelSource { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("itemDefectReturnShippingFeesAmount")]
        public virtual MonetaryAmount? ItemDefectReturnShippingFeesAmount { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("merchantReturnDays")]
        public virtual object? MerchantReturnDays { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("merchantReturnLink")]
        public virtual string? MerchantReturnLink { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("refundType")]
        public virtual RefundTypeEnumeration? RefundType { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("restockingFee")]
        public virtual object? RestockingFee { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("returnFees")]
        public virtual ReturnFeesEnumeration? ReturnFees { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("returnLabelSource")]
        public virtual ReturnLabelSourceEnumeration? ReturnLabelSource { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("returnMethod")]
        public virtual ReturnMethodEnumeration? ReturnMethod { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("returnPolicyCategory")]
        public virtual MerchantReturnEnumeration? ReturnPolicyCategory { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("returnPolicyCountry")]
        public virtual object? ReturnPolicyCountry { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("returnPolicySeasonalOverride")]
        public virtual MerchantReturnPolicySeasonalOverride? ReturnPolicySeasonalOverride { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("returnShippingFeesAmount")]
        public virtual MonetaryAmount? ReturnShippingFeesAmount { get; set; }

    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// </summary>
        [JsonPropertyName("validForMemberTier")]
        public virtual MemberProgramTier? ValidForMemberTier { get; set; }

    }
}
