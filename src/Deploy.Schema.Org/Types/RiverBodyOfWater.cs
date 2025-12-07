using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// </summary>
    public partial class RiverBodyOfWater : BodyOfWater
    {
        public RiverBodyOfWater()
        {
            Type = "RiverBodyOfWater";
        }

    }
}
