using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A golf course.
    /// </summary>
    public partial class GolfCourse : SportsActivityLocation
    {
        public GolfCourse()
        {
            Type = "GolfCourse";
        }

    }
}
