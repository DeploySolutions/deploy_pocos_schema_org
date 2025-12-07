using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.
    /// </summary>
    public partial class MotorizedBicycle : Vehicle
    {
        public MotorizedBicycle()
        {
            Type = "MotorizedBicycle";
        }

    }
}
