using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A value indicating a steering position.
    /// </summary>
    public partial class SteeringPositionValue : QualitativeValue
    {
        public SteeringPositionValue()
        {
            Type = "SteeringPositionValue";
        }

    }
}
