using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// </summary>
    public partial class EventStatusType : StatusEnumeration
    {
        public EventStatusType()
        {
            Type = "EventStatusType";
        }

    }
}
