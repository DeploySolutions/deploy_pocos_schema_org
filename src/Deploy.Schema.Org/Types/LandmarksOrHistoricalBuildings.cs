using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    public partial class LandmarksOrHistoricalBuildings : Place
    {
        public LandmarksOrHistoricalBuildings()
        {
            Type = "LandmarksOrHistoricalBuildings";
        }

    }
}
