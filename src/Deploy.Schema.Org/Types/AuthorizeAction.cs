using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of granting permission to an object.
    /// </summary>
    public partial class AuthorizeAction : AllocateAction
    {
        public AuthorizeAction()
        {
            Type = "AuthorizeAction";
        }

    /// <summary>
    /// The act of granting permission to an object.
    /// </summary>
        [JsonPropertyName("recipient")]
        public virtual object? Recipient { get; set; }

    }
}
