using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Theater performance.
    /// </summary>
    public partial class TheaterEvent : Event
    {
        public TheaterEvent()
        {
            Type = "TheaterEvent";
        }

    }
}
