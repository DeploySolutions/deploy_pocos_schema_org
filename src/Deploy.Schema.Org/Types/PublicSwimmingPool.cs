using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A public swimming pool.
    /// </summary>
    public partial class PublicSwimmingPool : SportsActivityLocation
    {
        public PublicSwimmingPool()
        {
            Type = "PublicSwimmingPool";
        }

    }
}
