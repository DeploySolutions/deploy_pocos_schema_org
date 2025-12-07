using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A garden store.
    /// </summary>
    public partial class GardenStore : Store
    {
        public GardenStore()
        {
            Type = "GardenStore";
        }

    }
}
