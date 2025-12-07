using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A travel agency.
    /// </summary>
    public partial class TravelAgency : LocalBusiness
    {
        public TravelAgency()
        {
            Type = "TravelAgency";
        }

    }
}
