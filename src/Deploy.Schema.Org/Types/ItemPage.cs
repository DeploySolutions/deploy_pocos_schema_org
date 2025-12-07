using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// </summary>
    public partial class ItemPage : WebPage
    {
        public ItemPage()
        {
            Type = "ItemPage";
        }

    }
}
