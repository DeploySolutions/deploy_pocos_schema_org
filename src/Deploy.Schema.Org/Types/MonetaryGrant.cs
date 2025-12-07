using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A monetary grant.
    /// </summary>
    public partial class MonetaryGrant : Grant
    {
        public MonetaryGrant()
        {
            Type = "MonetaryGrant";
        }

    /// <summary>
    /// A monetary grant.
    /// </summary>
        [JsonPropertyName("amount")]
        public virtual object? Amount { get; set; }

    /// <summary>
    /// A monetary grant.
    /// </summary>
        [JsonPropertyName("funder")]
        public virtual object? Funder { get; set; }

    }
}
