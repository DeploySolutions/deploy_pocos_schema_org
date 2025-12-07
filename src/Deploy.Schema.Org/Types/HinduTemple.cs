using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Hindu temple.
    /// </summary>
    public partial class HinduTemple : PlaceOfWorship
    {
        public HinduTemple()
        {
            Type = "HinduTemple";
        }

    }
}
