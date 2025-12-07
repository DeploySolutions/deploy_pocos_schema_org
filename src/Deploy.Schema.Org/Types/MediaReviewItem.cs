using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Represents an item or group of closely related items treated as a unit for the sake of evaluation in a [[MediaReview]]. Authorship etc. apply to the items rather than to the curation/grouping or reviewing party.
    /// </summary>
    public partial class MediaReviewItem : CreativeWork
    {
        public MediaReviewItem()
        {
            Type = "MediaReviewItem";
        }

    /// <summary>
    /// Represents an item or group of closely related items treated as a unit for the sake of evaluation in a [[MediaReview]]. Authorship etc. apply to the items rather than to the curation/grouping or reviewing party.
    /// </summary>
        [JsonPropertyName("mediaItemAppearance")]
        public virtual MediaObject? MediaItemAppearance { get; set; }

    }
}
