using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the [[text]] property, and its topic via [[about]], properties shared with all CreativeWorks.
    /// </summary>
    public partial class Comment : CreativeWork
    {
        public Comment()
        {
            Type = "Comment";
        }

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the [[text]] property, and its topic via [[about]], properties shared with all CreativeWorks.
    /// </summary>
        [JsonPropertyName("downvoteCount")]
        public virtual Integer? DownvoteCount { get; set; }

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the [[text]] property, and its topic via [[about]], properties shared with all CreativeWorks.
    /// </summary>
        [JsonPropertyName("parentItem")]
        public virtual object? ParentItem { get; set; }

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the [[text]] property, and its topic via [[about]], properties shared with all CreativeWorks.
    /// </summary>
        [JsonPropertyName("sharedContent")]
        public virtual CreativeWork? SharedContent { get; set; }

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the [[text]] property, and its topic via [[about]], properties shared with all CreativeWorks.
    /// </summary>
        [JsonPropertyName("upvoteCount")]
        public virtual Integer? UpvoteCount { get; set; }

    }
}
