using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Music event.
    /// </summary>
    public partial class MusicEvent : Event
    {
        public MusicEvent()
        {
            Type = "MusicEvent";
        }

    }
}
