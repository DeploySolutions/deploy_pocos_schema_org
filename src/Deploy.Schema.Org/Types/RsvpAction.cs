using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
    public partial class RsvpAction : InformAction
    {
        public RsvpAction()
        {
            Type = "RsvpAction";
        }

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
        [JsonPropertyName("additionalNumberOfGuests")]
        public virtual double? AdditionalNumberOfGuests { get; set; }

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
        [JsonPropertyName("comment")]
        public virtual Comment? Comment { get; set; }

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
        [JsonPropertyName("rsvpResponse")]
        public virtual RsvpResponseType? RsvpResponse { get; set; }

    }
}
