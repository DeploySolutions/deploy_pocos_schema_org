using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A graveyard.
    /// </summary>
    public partial class Cemetery : CivicStructure
    {
        public Cemetery()
        {
            Type = "Cemetery";
        }

    }
}
