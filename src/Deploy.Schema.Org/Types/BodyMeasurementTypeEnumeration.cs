using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates types (or dimensions) of a person's body measurements, for example for fitting of clothes.
    /// </summary>
    public partial class BodyMeasurementTypeEnumeration : MeasurementTypeEnumeration
    {
        public BodyMeasurementTypeEnumeration()
        {
            Type = "BodyMeasurementTypeEnumeration";
        }

    }
}
