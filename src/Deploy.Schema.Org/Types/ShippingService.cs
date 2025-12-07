using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// ShippingService represents the criteria used to determine if and how an offer could be shipped to a customer.
    /// </summary>
    public partial class ShippingService : StructuredValue
    {
        public ShippingService()
        {
            Type = "ShippingService";
        }

    /// <summary>
    /// ShippingService represents the criteria used to determine if and how an offer could be shipped to a customer.
    /// </summary>
        [JsonPropertyName("fulfillmentType")]
        public virtual FulfillmentTypeEnumeration? FulfillmentType { get; set; }

    /// <summary>
    /// ShippingService represents the criteria used to determine if and how an offer could be shipped to a customer.
    /// </summary>
        [JsonPropertyName("handlingTime")]
        public virtual object? HandlingTime { get; set; }

    /// <summary>
    /// ShippingService represents the criteria used to determine if and how an offer could be shipped to a customer.
    /// </summary>
        [JsonPropertyName("shippingConditions")]
        public virtual ShippingConditions? ShippingConditions { get; set; }

    /// <summary>
    /// ShippingService represents the criteria used to determine if and how an offer could be shipped to a customer.
    /// </summary>
        [JsonPropertyName("validForMemberTier")]
        public virtual MemberProgramTier? ValidForMemberTier { get; set; }

    }
}
