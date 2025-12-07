using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
    public partial class MerchantReturnPolicySeasonalOverride : Intangible
    {
        public MerchantReturnPolicySeasonalOverride()
        {
            Type = "MerchantReturnPolicySeasonalOverride";
        }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("endDate")]
        public virtual object? EndDate { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("merchantReturnDays")]
        public virtual object? MerchantReturnDays { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("refundType")]
        public virtual RefundTypeEnumeration? RefundType { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("restockingFee")]
        public virtual object? RestockingFee { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("returnFees")]
        public virtual ReturnFeesEnumeration? ReturnFees { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("returnMethod")]
        public virtual ReturnMethodEnumeration? ReturnMethod { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("returnPolicyCategory")]
        public virtual MerchantReturnEnumeration? ReturnPolicyCategory { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("returnShippingFeesAmount")]
        public virtual MonetaryAmount? ReturnShippingFeesAmount { get; set; }

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// </summary>
        [JsonPropertyName("startDate")]
        public virtual object? StartDate { get; set; }

    }
}
