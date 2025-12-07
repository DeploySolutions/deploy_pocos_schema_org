using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An advertising section of the page.
    /// </summary>
    public partial class WPAdBlock : WebPageElement
    {
        public WPAdBlock()
        {
            Type = "WPAdBlock";
        }

    }
}
