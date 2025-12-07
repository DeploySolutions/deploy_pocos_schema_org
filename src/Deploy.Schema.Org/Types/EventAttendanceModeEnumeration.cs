using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An EventAttendanceModeEnumeration value is one of potentially several modes of organising an event, relating to whether it is online or offline.
    /// </summary>
    public partial class EventAttendanceModeEnumeration : Enumeration
    {
        public EventAttendanceModeEnumeration()
        {
            Type = "EventAttendanceModeEnumeration";
        }

    }
}
