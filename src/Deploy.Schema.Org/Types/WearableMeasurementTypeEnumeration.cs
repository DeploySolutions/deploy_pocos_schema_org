using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates common types of measurement for wearables products.
    /// </summary>
    public partial class WearableMeasurementTypeEnumeration : MeasurementTypeEnumeration
    {
        public WearableMeasurementTypeEnumeration()
        {
            Type = "WearableMeasurementTypeEnumeration";
        }

    }
}
