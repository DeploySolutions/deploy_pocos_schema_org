using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A subway station.
    /// </summary>
    public partial class SubwayStation : CivicStructure
    {
        public SubwayStation()
        {
            Type = "SubwayStation";
        }

    }
}
