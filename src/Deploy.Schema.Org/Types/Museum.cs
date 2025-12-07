using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A museum.
    /// </summary>
    public partial class Museum : CivicStructure
    {
        public Museum()
        {
            Type = "Museum";
        }

    }
}
