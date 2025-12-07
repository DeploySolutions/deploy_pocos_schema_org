using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// </summary>
    public partial class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            Type = "Motorcycle";
        }

    }
}
