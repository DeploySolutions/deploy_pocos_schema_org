using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// </summary>
    public partial class PawnShop : Store
    {
        public PawnShop()
        {
            Type = "PawnShop";
        }

    }
}
