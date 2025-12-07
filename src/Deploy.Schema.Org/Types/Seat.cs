using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    public partial class Seat : Intangible
    {
        public Seat()
        {
            Type = "Seat";
        }

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
        [JsonPropertyName("seatingType")]
        public virtual object? SeatingType { get; set; }

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
        [JsonPropertyName("seatNumber")]
        public virtual string? SeatNumber { get; set; }

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
        [JsonPropertyName("seatRow")]
        public virtual string? SeatRow { get; set; }

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
        [JsonPropertyName("seatSection")]
        public virtual string? SeatSection { get; set; }

    }
}
