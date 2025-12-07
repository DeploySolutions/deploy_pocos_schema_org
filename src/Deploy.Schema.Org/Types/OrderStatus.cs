using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerated status values for Order.
    /// </summary>
    public partial class OrderStatus : StatusEnumeration
    {
        public OrderStatus()
        {
            Type = "OrderStatus";
        }

    }
}
