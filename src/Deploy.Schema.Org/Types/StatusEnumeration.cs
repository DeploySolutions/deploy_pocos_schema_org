using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Lists or enumerations dealing with status types.
    /// </summary>
    public partial class StatusEnumeration : Enumeration
    {
        public StatusEnumeration()
        {
            Type = "StatusEnumeration";
        }

    }
}
