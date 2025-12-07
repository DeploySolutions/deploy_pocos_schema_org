using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
    public partial class PropertyValue : StructuredValue
    {
        public PropertyValue()
        {
            Type = "PropertyValue";
        }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("maxValue")]
        public virtual double? MaxValue { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("measurementMethod")]
        public virtual object? MeasurementMethod { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("measurementTechnique")]
        public virtual object? MeasurementTechnique { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("minValue")]
        public virtual double? MinValue { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("propertyID")]
        public virtual object? PropertyID { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("unitCode")]
        public virtual object? UnitCode { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("unitText")]
        public virtual string? UnitText { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("value")]
        public virtual object? Value { get; set; }

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///     
    /// </summary>
        [JsonPropertyName("valueReference")]
        public virtual object? ValueReference { get; set; }

    }
}
