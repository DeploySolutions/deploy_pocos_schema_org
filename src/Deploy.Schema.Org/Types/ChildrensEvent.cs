using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    public partial class ChildrensEvent : Event
    {
        public ChildrensEvent()
        {
            Type = "ChildrensEvent";
        }

    }
}
