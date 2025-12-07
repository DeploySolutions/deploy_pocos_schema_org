using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A stadium.
    /// </summary>
    public partial class StadiumOrArena : CivicStructure
    {
        public StadiumOrArena()
        {
            Type = "StadiumOrArena";
        }

    }
}
