using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A reservation for air travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
    public partial class FlightReservation : Reservation
    {
        public FlightReservation()
        {
            Type = "FlightReservation";
        }

    /// <summary>
    /// A reservation for air travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
        [JsonPropertyName("boardingGroup")]
        public virtual string? BoardingGroup { get; set; }

    /// <summary>
    /// A reservation for air travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
        [JsonPropertyName("passengerPriorityStatus")]
        public virtual object? PassengerPriorityStatus { get; set; }

    /// <summary>
    /// A reservation for air travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
        [JsonPropertyName("passengerSequenceNumber")]
        public virtual string? PassengerSequenceNumber { get; set; }

    /// <summary>
    /// A reservation for air travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
        [JsonPropertyName("securityScreening")]
        public virtual string? SecurityScreening { get; set; }

    }
}
