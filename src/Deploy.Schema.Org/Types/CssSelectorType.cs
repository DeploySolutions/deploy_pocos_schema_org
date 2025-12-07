using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Text representing a CSS selector.
    /// </summary>
    public partial class CssSelectorType : SchemaObject
    {
        public CssSelectorType()
        {
            Type = "CssSelectorType";
        }

    }
}
