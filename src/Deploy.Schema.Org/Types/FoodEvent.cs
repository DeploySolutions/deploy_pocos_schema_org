using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Food event.
    /// </summary>
    public partial class FoodEvent : Event
    {
        public FoodEvent()
        {
            Type = "FoodEvent";
        }

    }
}
