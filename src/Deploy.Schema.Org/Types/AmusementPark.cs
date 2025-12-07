using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An amusement park.
    /// </summary>
    public partial class AmusementPark : EntertainmentBusiness
    {
        public AmusementPark()
        {
            Type = "AmusementPark";
        }

    }
}
