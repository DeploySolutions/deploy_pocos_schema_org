using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates common size groups for various product categories.
    /// </summary>
    public partial class SizeGroupEnumeration : Enumeration
    {
        public SizeGroupEnumeration()
        {
            Type = "SizeGroupEnumeration";
        }

    }
}
