using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A reservation for a taxi.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
    public partial class TaxiReservation : Reservation
    {
        public TaxiReservation()
        {
            Type = "TaxiReservation";
        }

    /// <summary>
    /// A reservation for a taxi.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
        [JsonPropertyName("partySize")]
        public virtual object? PartySize { get; set; }

    /// <summary>
    /// A reservation for a taxi.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
        [JsonPropertyName("pickupLocation")]
        public virtual Place? PickupLocation { get; set; }

    /// <summary>
    /// A reservation for a taxi.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
        [JsonPropertyName("pickupTime")]
        public virtual DateTime? PickupTime { get; set; }

    }
}
