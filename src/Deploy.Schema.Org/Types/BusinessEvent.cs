using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Business event.
    /// </summary>
    public partial class BusinessEvent : Event
    {
        public BusinessEvent()
        {
            Type = "BusinessEvent";
        }

    }
}
