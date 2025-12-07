using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A posting to a discussion forum.
    /// </summary>
    public partial class DiscussionForumPosting : SocialMediaPosting
    {
        public DiscussionForumPosting()
        {
            Type = "DiscussionForumPosting";
        }

    }
}
