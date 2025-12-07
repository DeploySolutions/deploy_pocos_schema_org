using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    public partial class OceanBodyOfWater : BodyOfWater
    {
        public OceanBodyOfWater()
        {
            Type = "OceanBodyOfWater";
        }

    }
}
