using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A value indicating which roadwheels will receive torque.
    /// </summary>
    public partial class DriveWheelConfigurationValue : QualitativeValue
    {
        public DriveWheelConfigurationValue()
        {
            Type = "DriveWheelConfigurationValue";
        }

    }
}
