using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A tourist information center.
    /// </summary>
    public partial class TouristInformationCenter : LocalBusiness
    {
        public TouristInformationCenter()
        {
            Type = "TouristInformationCenter";
        }

    }
}
