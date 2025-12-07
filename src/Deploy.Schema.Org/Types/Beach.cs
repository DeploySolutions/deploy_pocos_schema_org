using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Beach.
    /// </summary>
    public partial class Beach : CivicStructure
    {
        public Beach()
        {
            Type = "Beach";
        }

    }
}
