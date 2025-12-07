using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A retail good store.
    /// </summary>
    public partial class Store : LocalBusiness
    {
        public Store()
        {
            Type = "Store";
        }

    }
}
