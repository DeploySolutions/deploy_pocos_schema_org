using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// </summary>
    public partial class RsvpResponseType : Enumeration
    {
        public RsvpResponseType()
        {
            Type = "RsvpResponseType";
        }

    }
}
