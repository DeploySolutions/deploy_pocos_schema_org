using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bike store.
    /// </summary>
    public partial class BikeStore : Store
    {
        public BikeStore()
        {
            Type = "BikeStore";
        }

    }
}
