using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A value indicating a special usage of a car, e.g. commercial rental, driving school, or as a taxi.
    /// </summary>
    public partial class CarUsageType : Enumeration
    {
        public CarUsageType()
        {
            Type = "CarUsageType";
        }

    }
}
