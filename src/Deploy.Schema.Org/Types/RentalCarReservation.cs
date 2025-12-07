using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A reservation for a rental car.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    public partial class RentalCarReservation : Reservation
    {
        public RentalCarReservation()
        {
            Type = "RentalCarReservation";
        }

    /// <summary>
    /// A reservation for a rental car.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("dropoffLocation")]
        public virtual Place? DropoffLocation { get; set; }

    /// <summary>
    /// A reservation for a rental car.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("dropoffTime")]
        public virtual DateTime? DropoffTime { get; set; }

    /// <summary>
    /// A reservation for a rental car.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("pickupLocation")]
        public virtual Place? PickupLocation { get; set; }

    /// <summary>
    /// A reservation for a rental car.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
        [JsonPropertyName("pickupTime")]
        public virtual DateTime? PickupTime { get; set; }

    }
}
