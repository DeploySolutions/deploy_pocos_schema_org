using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Data type: Integer.
    /// </summary>
    public partial class Integer : SchemaObject
    {
        public Integer()
        {
            Type = "Integer";
        }

    }
}
