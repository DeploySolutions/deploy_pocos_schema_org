using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: A social dance.
    /// </summary>
    public partial class DanceEvent : Event
    {
        public DanceEvent()
        {
            Type = "DanceEvent";
        }

    }
}
