using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// </summary>
    public partial class TipAction : TradeAction
    {
        public TipAction()
        {
            Type = "TipAction";
        }

    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// </summary>
        [JsonPropertyName("recipient")]
        public virtual object? Recipient { get; set; }

    }
}
