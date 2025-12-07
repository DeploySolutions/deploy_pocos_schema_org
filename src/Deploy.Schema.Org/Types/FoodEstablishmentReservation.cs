using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A reservation to dine at a food-related business.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    public partial class FoodEstablishmentReservation : Reservation
    {
        public FoodEstablishmentReservation()
        {
            Type = "FoodEstablishmentReservation";
        }

    /// <summary>
    /// A reservation to dine at a food-related business.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("endTime")]
        public virtual object? EndTime { get; set; }

    /// <summary>
    /// A reservation to dine at a food-related business.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("partySize")]
        public virtual object? PartySize { get; set; }

    /// <summary>
    /// A reservation to dine at a food-related business.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("startTime")]
        public virtual object? StartTime { get; set; }

    }
}
