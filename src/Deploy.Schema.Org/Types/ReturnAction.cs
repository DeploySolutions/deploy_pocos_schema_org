using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    /// </summary>
    public partial class ReturnAction : TransferAction
    {
        public ReturnAction()
        {
            Type = "ReturnAction";
        }

    /// <summary>
    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    /// </summary>
        [JsonPropertyName("recipient")]
        public virtual object? Recipient { get; set; }

    }
}
