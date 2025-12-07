using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// All or part of a [[Dataset]] in downloadable form. 
    /// </summary>
    public partial class DataDownload : MediaObject
    {
        public DataDownload()
        {
            Type = "DataDownload";
        }

    /// <summary>
    /// All or part of a [[Dataset]] in downloadable form. 
    /// </summary>
        [JsonPropertyName("measurementMethod")]
        public virtual object? MeasurementMethod { get; set; }

    /// <summary>
    /// All or part of a [[Dataset]] in downloadable form. 
    /// </summary>
        [JsonPropertyName("measurementTechnique")]
        public virtual object? MeasurementTechnique { get; set; }

    }
}
