using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The action that takes in a math expression and directs users to a page potentially capable of solving/simplifying that expression.
    /// </summary>
    public partial class SolveMathAction : Action
    {
        public SolveMathAction()
        {
            Type = "SolveMathAction";
        }

    /// <summary>
    /// The action that takes in a math expression and directs users to a page potentially capable of solving/simplifying that expression.
    /// </summary>
        [JsonPropertyName("eduQuestionType")]
        public virtual string? EduQuestionType { get; set; }

    }
}
