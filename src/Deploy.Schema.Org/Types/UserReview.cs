using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A review created by an end-user (e.g. consumer, purchaser, attendee etc.), in contrast with [[CriticReview]].
    /// </summary>
    public partial class UserReview : Review
    {
        public UserReview()
        {
            Type = "UserReview";
        }

    }
}
