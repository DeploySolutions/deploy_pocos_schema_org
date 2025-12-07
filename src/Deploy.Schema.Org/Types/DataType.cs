using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The basic data types such as Integers, Strings, etc.
    /// </summary>
    public partial class DataType : SchemaObject
    {
        public DataType()
        {
            Type = "DataType";
        }

    }
}
