using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// One or more messages between organizations or people on a particular topic. Individual messages can be linked to the conversation with isPartOf or hasPart properties.
    /// </summary>
    public partial class Conversation : CreativeWork
    {
        public Conversation()
        {
            Type = "Conversation";
        }

    }
}
