using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates several types of return labels for product returns.
    /// </summary>
    public partial class ReturnLabelSourceEnumeration : Enumeration
    {
        public ReturnLabelSourceEnumeration()
        {
            Type = "ReturnLabelSourceEnumeration";
        }

    }
}
