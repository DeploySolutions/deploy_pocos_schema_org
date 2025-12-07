using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Data type: Floating number.
    /// </summary>
    public partial class Float : SchemaObject
    {
        public Float()
        {
            Type = "Float";
        }

    }
}
