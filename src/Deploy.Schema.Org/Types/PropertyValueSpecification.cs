using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Property value specification.
    /// </summary>
    public partial class PropertyValueSpecification : Intangible
    {
        public PropertyValueSpecification()
        {
            Type = "PropertyValueSpecification";
        }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("defaultValue")]
        public virtual object? DefaultValue { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("maxValue")]
        public virtual double? MaxValue { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("minValue")]
        public virtual double? MinValue { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("multipleValues")]
        public virtual bool? MultipleValues { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("readonlyValue")]
        public virtual bool? ReadonlyValue { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("stepValue")]
        public virtual double? StepValue { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("valueMaxLength")]
        public virtual double? ValueMaxLength { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("valueMinLength")]
        public virtual double? ValueMinLength { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("valueName")]
        public virtual string? ValueName { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("valuePattern")]
        public virtual string? ValuePattern { get; set; }

    /// <summary>
    /// A Property value specification.
    /// </summary>
        [JsonPropertyName("valueRequired")]
        public virtual bool? ValueRequired { get; set; }

    }
}
