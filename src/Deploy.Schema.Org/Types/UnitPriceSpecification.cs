using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
    public partial class UnitPriceSpecification : PriceSpecification
    {
        public UnitPriceSpecification()
        {
            Type = "UnitPriceSpecification";
        }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("billingDuration")]
        public virtual object? BillingDuration { get; set; }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("billingIncrement")]
        public virtual double? BillingIncrement { get; set; }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("billingStart")]
        public virtual double? BillingStart { get; set; }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("priceComponentType")]
        public virtual PriceComponentTypeEnumeration? PriceComponentType { get; set; }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("priceType")]
        public virtual object? PriceType { get; set; }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("referenceQuantity")]
        public virtual QuantitativeValue? ReferenceQuantity { get; set; }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("unitCode")]
        public virtual object? UnitCode { get; set; }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
        [JsonPropertyName("unitText")]
        public virtual string? UnitText { get; set; }

    }
}
