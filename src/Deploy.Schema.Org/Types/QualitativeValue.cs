using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
    public partial class QualitativeValue : Enumeration
    {
        public QualitativeValue()
        {
            Type = "QualitativeValue";
        }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("additionalProperty")]
        public virtual PropertyValue? AdditionalProperty { get; set; }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("equal")]
        public virtual QualitativeValue? Equal { get; set; }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("greater")]
        public virtual QualitativeValue? Greater { get; set; }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("greaterOrEqual")]
        public virtual QualitativeValue? GreaterOrEqual { get; set; }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("lesser")]
        public virtual QualitativeValue? Lesser { get; set; }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("lesserOrEqual")]
        public virtual QualitativeValue? LesserOrEqual { get; set; }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("nonEqual")]
        public virtual QualitativeValue? NonEqual { get; set; }

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// </summary>
        [JsonPropertyName("valueReference")]
        public virtual object? ValueReference { get; set; }

    }
}
