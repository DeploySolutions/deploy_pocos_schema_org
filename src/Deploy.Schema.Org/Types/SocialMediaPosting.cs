using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// </summary>
    public partial class SocialMediaPosting : Article
    {
        public SocialMediaPosting()
        {
            Type = "SocialMediaPosting";
        }

    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// </summary>
        [JsonPropertyName("sharedContent")]
        public virtual CreativeWork? SharedContent { get; set; }

    }
}
