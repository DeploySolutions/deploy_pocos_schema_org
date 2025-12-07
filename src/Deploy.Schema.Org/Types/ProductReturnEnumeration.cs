using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// ProductReturnEnumeration enumerates several kinds of product return policy. Note that this structure may not capture all aspects of the policy.
    /// </summary>
    public partial class ProductReturnEnumeration : Enumeration
    {
        public ProductReturnEnumeration()
        {
            Type = "ProductReturnEnumeration";
        }

    }
}
