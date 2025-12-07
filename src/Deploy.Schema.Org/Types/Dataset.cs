using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    public partial class Dataset : CreativeWork
    {
        public Dataset()
        {
            Type = "Dataset";
        }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("catalog")]
        public virtual DataCatalog? Catalog { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("datasetTimeInterval")]
        public virtual DateTime? DatasetTimeInterval { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("distribution")]
        public virtual DataDownload? Distribution { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("includedDataCatalog")]
        public virtual DataCatalog? IncludedDataCatalog { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("includedInDataCatalog")]
        public virtual DataCatalog? IncludedInDataCatalog { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("issn")]
        public virtual string? Issn { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("measurementMethod")]
        public virtual object? MeasurementMethod { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("measurementTechnique")]
        public virtual object? MeasurementTechnique { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("variableMeasured")]
        public virtual object? VariableMeasured { get; set; }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
        [JsonPropertyName("variablesMeasured")]
        public virtual object? VariablesMeasured { get; set; }

    }
}
