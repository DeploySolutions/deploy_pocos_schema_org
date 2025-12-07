using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.\n\nRelated actions:\n\n* [[FollowAction]]: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.
    /// </summary>
    public partial class BefriendAction : InteractAction
    {
        public BefriendAction()
        {
            Type = "BefriendAction";
        }

    }
}
