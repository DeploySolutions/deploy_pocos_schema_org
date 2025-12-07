using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A sports location, such as a playing field.
    /// </summary>
    public partial class SportsActivityLocation : LocalBusiness
    {
        public SportsActivityLocation()
        {
            Type = "SportsActivityLocation";
        }

    }
}
