using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumeration of common measurement types (or dimensions), for example "chest" for a person, "inseam" for pants, "gauge" for screws, or "wheel" for bicycles.
    /// </summary>
    public partial class MeasurementTypeEnumeration : Enumeration
    {
        public MeasurementTypeEnumeration()
        {
            Type = "MeasurementTypeEnumeration";
        }

    }
}
