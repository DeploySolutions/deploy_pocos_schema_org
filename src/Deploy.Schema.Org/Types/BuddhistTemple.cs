using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Buddhist temple.
    /// </summary>
    public partial class BuddhistTemple : PlaceOfWorship
    {
        public BuddhistTemple()
        {
            Type = "BuddhistTemple";
        }

    }
}
