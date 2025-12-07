using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An email message.
    /// </summary>
    public partial class EmailMessage : Message
    {
        public EmailMessage()
        {
            Type = "EmailMessage";
        }

    }
}
