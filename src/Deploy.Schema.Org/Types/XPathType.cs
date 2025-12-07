using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Text representing an XPath (typically but not necessarily version 1.0).
    /// </summary>
    public partial class XPathType : SchemaObject
    {
        public XPathType()
        {
            Type = "XPathType";
        }

    }
}
