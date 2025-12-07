using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
    public partial class Rating : Intangible
    {
        public Rating()
        {
            Type = "Rating";
        }

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
        [JsonPropertyName("author")]
        public virtual object? Author { get; set; }

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
        [JsonPropertyName("bestRating")]
        public virtual object? BestRating { get; set; }

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
        [JsonPropertyName("ratingExplanation")]
        public virtual string? RatingExplanation { get; set; }

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
        [JsonPropertyName("ratingValue")]
        public virtual object? RatingValue { get; set; }

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
        [JsonPropertyName("reviewAspect")]
        public virtual string? ReviewAspect { get; set; }

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
        [JsonPropertyName("worstRating")]
        public virtual object? WorstRating { get; set; }

    }
}
