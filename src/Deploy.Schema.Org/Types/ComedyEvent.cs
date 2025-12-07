using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Comedy event.
    /// </summary>
    public partial class ComedyEvent : Event
    {
        public ComedyEvent()
        {
            Type = "ComedyEvent";
        }

    }
}
