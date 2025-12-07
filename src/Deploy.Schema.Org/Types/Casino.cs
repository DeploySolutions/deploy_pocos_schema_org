using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A casino.
    /// </summary>
    public partial class Casino : EntertainmentBusiness
    {
        public Casino()
        {
            Type = "Casino";
        }

    }
}
