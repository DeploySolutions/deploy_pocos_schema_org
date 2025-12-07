using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A text file. The text can be unformatted or contain markup, html, etc.
    /// </summary>
    public partial class TextObject : MediaObject
    {
        public TextObject()
        {
            Type = "TextObject";
        }

    }
}
