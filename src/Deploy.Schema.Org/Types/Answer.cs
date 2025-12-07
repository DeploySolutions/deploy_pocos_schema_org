using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
    public partial class Answer : Comment
    {
        public Answer()
        {
            Type = "Answer";
        }

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
        [JsonPropertyName("answerExplanation")]
        public virtual object? AnswerExplanation { get; set; }

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
        [JsonPropertyName("parentItem")]
        public virtual object? ParentItem { get; set; }

    }
}
