using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A grocery store.
    /// </summary>
    public partial class GroceryStore : Store
    {
        public GroceryStore()
        {
            Type = "GroceryStore";
        }

    }
}
