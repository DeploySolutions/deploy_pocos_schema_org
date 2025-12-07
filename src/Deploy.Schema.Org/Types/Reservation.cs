using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
    public partial class Reservation : Intangible
    {
        public Reservation()
        {
            Type = "Reservation";
        }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("bookingAgent")]
        public virtual object? BookingAgent { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("bookingTime")]
        public virtual DateTime? BookingTime { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("broker")]
        public virtual object? Broker { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("modifiedTime")]
        public virtual DateTime? ModifiedTime { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("priceCurrency")]
        public virtual string? PriceCurrency { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("programMembershipUsed")]
        public virtual ProgramMembership? ProgramMembershipUsed { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("reservationFor")]
        public virtual Thing? ReservationFor { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("reservationId")]
        public virtual string? ReservationId { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("reservationStatus")]
        public virtual ReservationStatusType? ReservationStatus { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("reservedTicket")]
        public virtual Ticket? ReservedTicket { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("totalPrice")]
        public virtual object? TotalPrice { get; set; }

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// </summary>
        [JsonPropertyName("underName")]
        public virtual object? UnderName { get; set; }

    }
}
