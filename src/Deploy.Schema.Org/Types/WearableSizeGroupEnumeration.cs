using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates common size groups (also known as "size types") for wearable products.
    /// </summary>
    public partial class WearableSizeGroupEnumeration : SizeGroupEnumeration
    {
        public WearableSizeGroupEnumeration()
        {
            Type = "WearableSizeGroupEnumeration";
        }

    }
}
