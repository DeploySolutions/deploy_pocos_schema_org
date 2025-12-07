using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A clothing store.
    /// </summary>
    public partial class ClothingStore : Store
    {
        public ClothingStore()
        {
            Type = "ClothingStore";
        }

    }
}
