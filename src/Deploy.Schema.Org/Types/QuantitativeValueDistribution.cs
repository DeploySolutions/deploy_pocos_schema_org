using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
    public partial class QuantitativeValueDistribution : StructuredValue
    {
        public QuantitativeValueDistribution()
        {
            Type = "QuantitativeValueDistribution";
        }

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
        [JsonPropertyName("median")]
        public virtual double? Median { get; set; }

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
        [JsonPropertyName("percentile10")]
        public virtual double? Percentile10 { get; set; }

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
        [JsonPropertyName("percentile25")]
        public virtual double? Percentile25 { get; set; }

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
        [JsonPropertyName("percentile75")]
        public virtual double? Percentile75 { get; set; }

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
        [JsonPropertyName("percentile90")]
        public virtual double? Percentile90 { get; set; }

    }
}
