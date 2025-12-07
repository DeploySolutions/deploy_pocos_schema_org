using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    public partial class ReservationPackage : Reservation
    {
        public ReservationPackage()
        {
            Type = "ReservationPackage";
        }

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
        [JsonPropertyName("subReservation")]
        public virtual Reservation? SubReservation { get; set; }

    }
}
