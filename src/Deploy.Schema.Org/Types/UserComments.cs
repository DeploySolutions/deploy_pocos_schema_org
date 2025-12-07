using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// </summary>
    public partial class UserComments : UserInteraction
    {
        public UserComments()
        {
            Type = "UserComments";
        }

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// </summary>
        [JsonPropertyName("commentText")]
        public virtual string? CommentText { get; set; }

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// </summary>
        [JsonPropertyName("commentTime")]
        public virtual object? CommentTime { get; set; }

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// </summary>
        [JsonPropertyName("creator")]
        public virtual object? Creator { get; set; }

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// </summary>
        [JsonPropertyName("discusses")]
        public virtual CreativeWork? Discusses { get; set; }

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// </summary>
        [JsonPropertyName("replyToUrl")]
        public virtual string? ReplyToUrl { get; set; }

    }
}
