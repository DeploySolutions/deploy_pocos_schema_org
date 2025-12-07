using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An event venue.
    /// </summary>
    public partial class EventVenue : CivicStructure
    {
        public EventVenue()
        {
            Type = "EventVenue";
        }

    }
}
