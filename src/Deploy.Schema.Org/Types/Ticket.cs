using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
    public partial class Ticket : Intangible
    {
        public Ticket()
        {
            Type = "Ticket";
        }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("dateIssued")]
        public virtual object? DateIssued { get; set; }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("issuedBy")]
        public virtual Organization? IssuedBy { get; set; }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("priceCurrency")]
        public virtual string? PriceCurrency { get; set; }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("ticketedSeat")]
        public virtual Seat? TicketedSeat { get; set; }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("ticketNumber")]
        public virtual string? TicketNumber { get; set; }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("ticketToken")]
        public virtual object? TicketToken { get; set; }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("totalPrice")]
        public virtual object? TotalPrice { get; set; }

    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// </summary>
        [JsonPropertyName("underName")]
        public virtual object? UnderName { get; set; }

    }
}
