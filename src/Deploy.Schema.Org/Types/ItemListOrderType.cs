using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// </summary>
    public partial class ItemListOrderType : Enumeration
    {
        public ItemListOrderType()
        {
            Type = "ItemListOrderType";
        }

    }
}
