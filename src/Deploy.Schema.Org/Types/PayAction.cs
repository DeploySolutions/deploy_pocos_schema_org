using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    public partial class PayAction : TradeAction
    {
        public PayAction()
        {
            Type = "PayAction";
        }

    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
        [JsonPropertyName("recipient")]
        public virtual object? Recipient { get; set; }

    }
}
