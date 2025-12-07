using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of posing a question / favor to someone.\n\nRelated actions:\n\n* [[ReplyAction]]: Appears generally as a response to AskAction.
    /// </summary>
    public partial class AskAction : CommunicateAction
    {
        public AskAction()
        {
            Type = "AskAction";
        }

    /// <summary>
    /// The act of posing a question / favor to someone.\n\nRelated actions:\n\n* [[ReplyAction]]: Appears generally as a response to AskAction.
    /// </summary>
        [JsonPropertyName("question")]
        public virtual Question? Question { get; set; }

    }
}
