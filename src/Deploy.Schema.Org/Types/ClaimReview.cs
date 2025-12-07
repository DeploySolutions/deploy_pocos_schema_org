using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// </summary>
    public partial class ClaimReview : Review
    {
        public ClaimReview()
        {
            Type = "ClaimReview";
        }

    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// </summary>
        [JsonPropertyName("claimReviewed")]
        public virtual string? ClaimReviewed { get; set; }

    }
}
