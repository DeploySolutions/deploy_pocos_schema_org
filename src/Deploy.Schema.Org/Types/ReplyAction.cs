using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to [[AskAction]].\n\nRelated actions:\n\n* [[AskAction]]: Appears generally as an origin of a ReplyAction.
    /// </summary>
    public partial class ReplyAction : CommunicateAction
    {
        public ReplyAction()
        {
            Type = "ReplyAction";
        }

    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to [[AskAction]].\n\nRelated actions:\n\n* [[AskAction]]: Appears generally as an origin of a ReplyAction.
    /// </summary>
        [JsonPropertyName("resultComment")]
        public virtual Comment? ResultComment { get; set; }

    }
}
