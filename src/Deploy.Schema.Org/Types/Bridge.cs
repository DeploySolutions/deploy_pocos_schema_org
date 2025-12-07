using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bridge.
    /// </summary>
    public partial class Bridge : CivicStructure
    {
        public Bridge()
        {
            Type = "Bridge";
        }

    }
}
