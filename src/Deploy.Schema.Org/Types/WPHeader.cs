using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The header section of the page.
    /// </summary>
    public partial class WPHeader : WebPageElement
    {
        public WPHeader()
        {
            Type = "WPHeader";
        }

    }
}
