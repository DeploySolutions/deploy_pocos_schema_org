using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    public partial class VisualArtsEvent : Event
    {
        public VisualArtsEvent()
        {
            Type = "VisualArtsEvent";
        }

    }
}
