using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates several kinds of product return refund types.
    /// </summary>
    public partial class RefundTypeEnumeration : Enumeration
    {
        public RefundTypeEnumeration()
        {
            Type = "RefundTypeEnumeration";
        }

    }
}
