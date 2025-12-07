using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A terminal for boats, ships, and other water vessels.
    /// </summary>
    public partial class BoatTerminal : CivicStructure
    {
        public BoatTerminal()
        {
            Type = "BoatTerminal";
        }

    }
}
