using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// </summary>
    public partial class SizeSpecification : QualitativeValue
    {
        public SizeSpecification()
        {
            Type = "SizeSpecification";
        }

    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// </summary>
        [JsonPropertyName("hasMeasurement")]
        public virtual QuantitativeValue? HasMeasurement { get; set; }

    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// </summary>
        [JsonPropertyName("sizeGroup")]
        public virtual object? SizeGroup { get; set; }

    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// </summary>
        [JsonPropertyName("sizeSystem")]
        public virtual object? SizeSystem { get; set; }

    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// </summary>
        [JsonPropertyName("suggestedAge")]
        public virtual QuantitativeValue? SuggestedAge { get; set; }

    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// </summary>
        [JsonPropertyName("suggestedGender")]
        public virtual object? SuggestedGender { get; set; }

    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// </summary>
        [JsonPropertyName("suggestedMeasurement")]
        public virtual QuantitativeValue? SuggestedMeasurement { get; set; }

    }
}
