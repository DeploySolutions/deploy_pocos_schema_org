using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates several kinds of product return policies.
    /// </summary>
    public partial class MerchantReturnEnumeration : Enumeration
    {
        public MerchantReturnEnumeration()
        {
            Type = "MerchantReturnEnumeration";
        }

    }
}
