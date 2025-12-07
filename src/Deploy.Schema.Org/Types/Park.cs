using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A park.
    /// </summary>
    public partial class Park : CivicStructure
    {
        public Park()
        {
            Type = "Park";
        }

    }
}
