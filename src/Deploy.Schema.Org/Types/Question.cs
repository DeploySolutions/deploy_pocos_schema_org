using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
    public partial class Question : Comment
    {
        public Question()
        {
            Type = "Question";
        }

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
        [JsonPropertyName("acceptedAnswer")]
        public virtual object? AcceptedAnswer { get; set; }

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
        [JsonPropertyName("answerCount")]
        public virtual Integer? AnswerCount { get; set; }

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
        [JsonPropertyName("eduQuestionType")]
        public virtual string? EduQuestionType { get; set; }

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
        [JsonPropertyName("parentItem")]
        public virtual object? ParentItem { get; set; }

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
        [JsonPropertyName("suggestedAnswer")]
        public virtual object? SuggestedAnswer { get; set; }

    }
}
