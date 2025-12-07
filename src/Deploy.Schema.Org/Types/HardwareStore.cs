using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A hardware store.
    /// </summary>
    public partial class HardwareStore : Store
    {
        public HardwareStore()
        {
            Type = "HardwareStore";
        }

    }
}
