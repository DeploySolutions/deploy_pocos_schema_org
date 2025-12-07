using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An electronics store.
    /// </summary>
    public partial class ElectronicsStore : Store
    {
        public ElectronicsStore()
        {
            Type = "ElectronicsStore";
        }

    }
}
