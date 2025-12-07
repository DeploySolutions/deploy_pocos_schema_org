using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    public partial class SiteNavigationElement : WebPageElement
    {
        public SiteNavigationElement()
        {
            Type = "SiteNavigationElement";
        }

    }
}
