using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates common size systems specific for wearable products.
    /// </summary>
    public partial class WearableSizeSystemEnumeration : SizeSystemEnumeration
    {
        public WearableSizeSystemEnumeration()
        {
            Type = "WearableSizeSystemEnumeration";
        }

    }
}
