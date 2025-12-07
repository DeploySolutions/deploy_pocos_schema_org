using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    public partial class FireStation : CivicStructure
    {
        public FireStation()
        {
            Type = "FireStation";
        }

    }
}
