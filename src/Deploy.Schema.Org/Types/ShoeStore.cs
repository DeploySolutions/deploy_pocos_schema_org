using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A shoe store.
    /// </summary>
    public partial class ShoeStore : Store
    {
        public ShoeStore()
        {
            Type = "ShoeStore";
        }

    }
}
