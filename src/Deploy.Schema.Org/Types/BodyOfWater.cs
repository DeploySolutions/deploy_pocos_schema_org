using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// </summary>
    public partial class BodyOfWater : Landform
    {
        public BodyOfWater()
        {
            Type = "BodyOfWater";
        }

    }
}
