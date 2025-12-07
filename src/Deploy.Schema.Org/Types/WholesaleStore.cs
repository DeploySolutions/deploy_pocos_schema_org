using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A wholesale store.
    /// </summary>
    public partial class WholesaleStore : Store
    {
        public WholesaleStore()
        {
            Type = "WholesaleStore";
        }

    }
}
