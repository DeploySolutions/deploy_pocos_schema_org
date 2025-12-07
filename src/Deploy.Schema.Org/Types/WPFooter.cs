using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The footer section of the page.
    /// </summary>
    public partial class WPFooter : WebPageElement
    {
        public WPFooter()
        {
            Type = "WPFooter";
        }

    }
}
