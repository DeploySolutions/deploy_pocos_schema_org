using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    public partial class AggregateRating : Rating
    {
        public AggregateRating()
        {
            Type = "AggregateRating";
        }

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
        [JsonPropertyName("itemReviewed")]
        public virtual Thing? ItemReviewed { get; set; }

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
        [JsonPropertyName("ratingCount")]
        public virtual Integer? RatingCount { get; set; }

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
        [JsonPropertyName("reviewCount")]
        public virtual Integer? ReviewCount { get; set; }

    }
}
