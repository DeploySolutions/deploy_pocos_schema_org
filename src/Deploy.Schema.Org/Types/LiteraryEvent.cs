using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Literary event.
    /// </summary>
    public partial class LiteraryEvent : Event
    {
        public LiteraryEvent()
        {
            Type = "LiteraryEvent";
        }

    }
}
