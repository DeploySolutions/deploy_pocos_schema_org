using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerated status values for Reservation.
    /// </summary>
    public partial class ReservationStatusType : StatusEnumeration
    {
        public ReservationStatusType()
        {
            Type = "ReservationStatusType";
        }

    }
}
