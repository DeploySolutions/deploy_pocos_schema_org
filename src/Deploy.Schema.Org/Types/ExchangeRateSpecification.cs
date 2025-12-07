using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A structured value representing exchange rate.
    /// </summary>
    public partial class ExchangeRateSpecification : StructuredValue
    {
        public ExchangeRateSpecification()
        {
            Type = "ExchangeRateSpecification";
        }

    /// <summary>
    /// A structured value representing exchange rate.
    /// </summary>
        [JsonPropertyName("currency")]
        public virtual string? Currency { get; set; }

    /// <summary>
    /// A structured value representing exchange rate.
    /// </summary>
        [JsonPropertyName("currentExchangeRate")]
        public virtual UnitPriceSpecification? CurrentExchangeRate { get; set; }

    /// <summary>
    /// A structured value representing exchange rate.
    /// </summary>
        [JsonPropertyName("exchangeRateSpread")]
        public virtual object? ExchangeRateSpread { get; set; }

    }
}
