using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    public partial class CommentAction : CommunicateAction
    {
        public CommentAction()
        {
            Type = "CommentAction";
        }

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
        [JsonPropertyName("resultComment")]
        public virtual Comment? ResultComment { get; set; }

    }
}
