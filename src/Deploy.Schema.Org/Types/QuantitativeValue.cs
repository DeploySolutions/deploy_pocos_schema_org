using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    public partial class QuantitativeValue : StructuredValue
    {
        public QuantitativeValue()
        {
            Type = "QuantitativeValue";
        }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
        [JsonPropertyName("additionalProperty")]
        public virtual PropertyValue? AdditionalProperty { get; set; }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
        [JsonPropertyName("maxValue")]
        public virtual double? MaxValue { get; set; }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
        [JsonPropertyName("minValue")]
        public virtual double? MinValue { get; set; }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
        [JsonPropertyName("unitCode")]
        public virtual object? UnitCode { get; set; }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
        [JsonPropertyName("unitText")]
        public virtual string? UnitText { get; set; }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
        [JsonPropertyName("value")]
        public virtual object? Value { get; set; }

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
        [JsonPropertyName("valueReference")]
        public virtual object? ValueReference { get; set; }

    }
}
