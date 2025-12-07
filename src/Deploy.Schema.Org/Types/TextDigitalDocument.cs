using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    public partial class TextDigitalDocument : DigitalDocument
    {
        public TextDigitalDocument()
        {
            Type = "TextDigitalDocument";
        }

    }
}
