using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// </summary>
    public partial class ReviewAction : AssessAction
    {
        public ReviewAction()
        {
            Type = "ReviewAction";
        }

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// </summary>
        [JsonPropertyName("resultReview")]
        public virtual Review? ResultReview { get; set; }

    }
}
