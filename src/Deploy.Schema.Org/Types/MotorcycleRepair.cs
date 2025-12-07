using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A motorcycle repair shop.
    /// </summary>
    public partial class MotorcycleRepair : AutomotiveBusiness
    {
        public MotorcycleRepair()
        {
            Type = "MotorcycleRepair";
        }

    }
}
