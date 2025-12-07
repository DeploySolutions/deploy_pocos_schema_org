using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
    public partial class ShippingConditions : StructuredValue
    {
        public ShippingConditions()
        {
            Type = "ShippingConditions";
        }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("depth")]
        public virtual object? Depth { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("doesNotShip")]
        public virtual bool? DoesNotShip { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("height")]
        public virtual object? Height { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("numItems")]
        public virtual QuantitativeValue? NumItems { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("orderValue")]
        public virtual MonetaryAmount? OrderValue { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("seasonalOverride")]
        public virtual OpeningHoursSpecification? SeasonalOverride { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("shippingDestination")]
        public virtual DefinedRegion? ShippingDestination { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("shippingOrigin")]
        public virtual DefinedRegion? ShippingOrigin { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("shippingRate")]
        public virtual object? ShippingRate { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("transitTime")]
        public virtual object? TransitTime { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("weight")]
        public virtual object? Weight { get; set; }

    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// </summary>
        [JsonPropertyName("width")]
        public virtual object? Width { get; set; }

    }
}
