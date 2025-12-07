using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    public partial class LodgingReservation : Reservation
    {
        public LodgingReservation()
        {
            Type = "LodgingReservation";
        }

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("checkinTime")]
        public virtual object? CheckinTime { get; set; }

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("checkoutTime")]
        public virtual object? CheckoutTime { get; set; }

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("lodgingUnitDescription")]
        public virtual string? LodgingUnitDescription { get; set; }

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("lodgingUnitType")]
        public virtual object? LodgingUnitType { get; set; }

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("numAdults")]
        public virtual object? NumAdults { get; set; }

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("numChildren")]
        public virtual object? NumChildren { get; set; }

    }
}
