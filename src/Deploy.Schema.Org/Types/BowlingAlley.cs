using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bowling alley.
    /// </summary>
    public partial class BowlingAlley : SportsActivityLocation
    {
        public BowlingAlley()
        {
            Type = "BowlingAlley";
        }

    }
}
