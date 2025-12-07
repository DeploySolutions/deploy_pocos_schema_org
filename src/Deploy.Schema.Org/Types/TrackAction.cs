using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent tracks an object for updates.\n\nRelated actions:\n\n* [[FollowAction]]: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.\n* [[SubscribeAction]]: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.
    /// </summary>
    public partial class TrackAction : FindAction
    {
        public TrackAction()
        {
            Type = "TrackAction";
        }

    /// <summary>
    /// An agent tracks an object for updates.\n\nRelated actions:\n\n* [[FollowAction]]: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.\n* [[SubscribeAction]]: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.
    /// </summary>
        [JsonPropertyName("deliveryMethod")]
        public virtual DeliveryMethod? DeliveryMethod { get; set; }

    }
}
