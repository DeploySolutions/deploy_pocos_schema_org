using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A comedy club.
    /// </summary>
    public partial class ComedyClub : EntertainmentBusiness
    {
        public ComedyClub()
        {
            Type = "ComedyClub";
        }

    }
}
