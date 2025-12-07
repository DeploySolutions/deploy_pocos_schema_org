using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A furniture store.
    /// </summary>
    public partial class FurnitureStore : Store
    {
        public FurnitureStore()
        {
            Type = "FurnitureStore";
        }

    }
}
