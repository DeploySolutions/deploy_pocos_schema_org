using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Sales event.
    /// </summary>
    public partial class SaleEvent : Event
    {
        public SaleEvent()
        {
            Type = "SaleEvent";
        }

    }
}
