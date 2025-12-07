using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// </summary>
    public partial class SeaBodyOfWater : BodyOfWater
    {
        public SeaBodyOfWater()
        {
            Type = "SeaBodyOfWater";
        }

    }
}
