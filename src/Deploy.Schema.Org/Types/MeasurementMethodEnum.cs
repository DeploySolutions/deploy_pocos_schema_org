using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumeration(s) for use with [[measurementMethod]].
    /// </summary>
    public partial class MeasurementMethodEnum : Enumeration
    {
        public MeasurementMethodEnum()
        {
            Type = "MeasurementMethodEnum";
        }

    }
}
