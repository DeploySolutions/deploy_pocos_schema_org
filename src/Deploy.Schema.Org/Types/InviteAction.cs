using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// </summary>
    public partial class InviteAction : CommunicateAction
    {
        public InviteAction()
        {
            Type = "InviteAction";
        }

    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// </summary>
        [JsonPropertyName("event")]
        public virtual Event? Event { get; set; }

    }
}
