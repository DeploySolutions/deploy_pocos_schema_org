using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Collection page.
    /// </summary>
    public partial class CollectionPage : WebPage
    {
        public CollectionPage()
        {
            Type = "CollectionPage";
        }

    }
}
