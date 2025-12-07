using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An outlet store.
    /// </summary>
    public partial class OutletStore : Store
    {
        public OutletStore()
        {
            Type = "OutletStore";
        }

    }
}
