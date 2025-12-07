using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A reservation for train travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// </summary>
    public partial class TrainReservation : Reservation
    {
        public TrainReservation()
        {
            Type = "TrainReservation";
        }

    }
}
