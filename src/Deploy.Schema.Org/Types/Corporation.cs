using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Organization: A business corporation.
    /// </summary>
    public partial class Corporation : Organization
    {
        public Corporation()
        {
            Type = "Corporation";
        }

    /// <summary>
    /// Organization: A business corporation.
    /// </summary>
        [JsonPropertyName("tickerSymbol")]
        public virtual string? TickerSymbol { get; set; }

    }
}
