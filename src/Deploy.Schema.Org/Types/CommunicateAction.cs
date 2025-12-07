using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
    public partial class CommunicateAction : InteractAction
    {
        public CommunicateAction()
        {
            Type = "CommunicateAction";
        }

    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
        [JsonPropertyName("about")]
        public virtual Thing? About { get; set; }

    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
        [JsonPropertyName("inLanguage")]
        public virtual object? InLanguage { get; set; }

    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
        [JsonPropertyName("language")]
        public virtual Language? Language { get; set; }

    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// </summary>
        [JsonPropertyName("recipient")]
        public virtual object? Recipient { get; set; }

    }
}
