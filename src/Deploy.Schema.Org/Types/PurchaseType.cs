using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates a purchase type for an item.
    /// </summary>
    public partial class PurchaseType : Enumeration
    {
        public PurchaseType()
        {
            Type = "PurchaseType";
        }

    }
}
