using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A motorcycle dealer.
    /// </summary>
    public partial class MotorcycleDealer : AutomotiveBusiness
    {
        public MotorcycleDealer()
        {
            Type = "MotorcycleDealer";
        }

    }
}
