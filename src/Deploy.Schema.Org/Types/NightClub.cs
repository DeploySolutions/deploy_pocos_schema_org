using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A nightclub or discotheque.
    /// </summary>
    public partial class NightClub : EntertainmentBusiness
    {
        public NightClub()
        {
            Type = "NightClub";
        }

    }
}
