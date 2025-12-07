using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates several kinds of policies for product return fees.
    /// </summary>
    public partial class ReturnFeesEnumeration : Enumeration
    {
        public ReturnFeesEnumeration()
        {
            Type = "ReturnFeesEnumeration";
        }

    }
}
