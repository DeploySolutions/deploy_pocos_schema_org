using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// </summary>
    public partial class UserTweets : UserInteraction
    {
        public UserTweets()
        {
            Type = "UserTweets";
        }

    }
}
