using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A sidebar section of the page.
    /// </summary>
    public partial class WPSideBar : WebPageElement
    {
        public WPSideBar()
        {
            Type = "WPSideBar";
        }

    }
}
