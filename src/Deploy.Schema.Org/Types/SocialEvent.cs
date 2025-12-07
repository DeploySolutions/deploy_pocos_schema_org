using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Social event.
    /// </summary>
    public partial class SocialEvent : Event
    {
        public SocialEvent()
        {
            Type = "SocialEvent";
        }

    }
}
