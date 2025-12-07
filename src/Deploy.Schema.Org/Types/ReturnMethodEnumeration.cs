using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates several types of product return methods.
    /// </summary>
    public partial class ReturnMethodEnumeration : Enumeration
    {
        public ReturnMethodEnumeration()
        {
            Type = "ReturnMethodEnumeration";
        }

    }
}
