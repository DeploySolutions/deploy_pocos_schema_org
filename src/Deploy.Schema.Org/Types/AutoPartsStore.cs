using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An auto parts store.
    /// </summary>
    public partial class AutoPartsStore : Store
    {
        public AutoPartsStore()
        {
            Type = "AutoPartsStore";
        }

    }
}
