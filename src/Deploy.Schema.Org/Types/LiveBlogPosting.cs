using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [[LiveBlogPosting]] is a [[BlogPosting]] intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
    public partial class LiveBlogPosting : BlogPosting
    {
        public LiveBlogPosting()
        {
            Type = "LiveBlogPosting";
        }

    /// <summary>
    /// A [[LiveBlogPosting]] is a [[BlogPosting]] intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
        [JsonPropertyName("coverageEndTime")]
        public virtual DateTime? CoverageEndTime { get; set; }

    /// <summary>
    /// A [[LiveBlogPosting]] is a [[BlogPosting]] intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
        [JsonPropertyName("coverageStartTime")]
        public virtual DateTime? CoverageStartTime { get; set; }

    /// <summary>
    /// A [[LiveBlogPosting]] is a [[BlogPosting]] intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
        [JsonPropertyName("liveBlogUpdate")]
        public virtual BlogPosting? LiveBlogUpdate { get; set; }

    }
}
