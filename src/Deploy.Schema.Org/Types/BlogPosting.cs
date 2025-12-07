using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A blog post.
    /// </summary>
    public partial class BlogPosting : SocialMediaPosting
    {
        public BlogPosting()
        {
            Type = "BlogPosting";
        }

    }
}
