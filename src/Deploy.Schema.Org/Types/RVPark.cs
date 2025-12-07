using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// </summary>
    public partial class RVPark : CivicStructure
    {
        public RVPark()
        {
            Type = "RVPark";
        }

    }
}
