using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A collection of datasets.
    /// </summary>
    public partial class DataCatalog : CreativeWork
    {
        public DataCatalog()
        {
            Type = "DataCatalog";
        }

    /// <summary>
    /// A collection of datasets.
    /// </summary>
        [JsonPropertyName("dataset")]
        public virtual Dataset? Dataset { get; set; }

    /// <summary>
    /// A collection of datasets.
    /// </summary>
        [JsonPropertyName("measurementMethod")]
        public virtual object? MeasurementMethod { get; set; }

    /// <summary>
    /// A collection of datasets.
    /// </summary>
        [JsonPropertyName("measurementTechnique")]
        public virtual object? MeasurementTechnique { get; set; }

    }
}
