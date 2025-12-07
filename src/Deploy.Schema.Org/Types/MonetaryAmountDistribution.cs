using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A statistical distribution of monetary amounts.
    /// </summary>
    public partial class MonetaryAmountDistribution : QuantitativeValueDistribution
    {
        public MonetaryAmountDistribution()
        {
            Type = "MonetaryAmountDistribution";
        }

    /// <summary>
    /// A statistical distribution of monetary amounts.
    /// </summary>
        [JsonPropertyName("currency")]
        public virtual string? Currency { get; set; }

    }
}
