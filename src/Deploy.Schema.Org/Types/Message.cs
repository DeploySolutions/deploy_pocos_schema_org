using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    public partial class Message : CreativeWork
    {
        public Message()
        {
            Type = "Message";
        }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("bccRecipient")]
        public virtual object? BccRecipient { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("ccRecipient")]
        public virtual object? CcRecipient { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("dateRead")]
        public virtual object? DateRead { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("dateReceived")]
        public virtual DateTime? DateReceived { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("dateSent")]
        public virtual DateTime? DateSent { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("messageAttachment")]
        public virtual CreativeWork? MessageAttachment { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("recipient")]
        public virtual object? Recipient { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("sender")]
        public virtual object? Sender { get; set; }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
        [JsonPropertyName("toRecipient")]
        public virtual object? ToRecipient { get; set; }

    }
}
