using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// ServicePeriod represents a duration with some constraints about cutoff time and business days. This is used e.g. in shipping for handling times or transit time.
    /// </summary>
    public partial class ServicePeriod : StructuredValue
    {
        public ServicePeriod()
        {
            Type = "ServicePeriod";
        }

    /// <summary>
    /// ServicePeriod represents a duration with some constraints about cutoff time and business days. This is used e.g. in shipping for handling times or transit time.
    /// </summary>
        [JsonPropertyName("businessDays")]
        public virtual object? BusinessDays { get; set; }

    /// <summary>
    /// ServicePeriod represents a duration with some constraints about cutoff time and business days. This is used e.g. in shipping for handling times or transit time.
    /// </summary>
        [JsonPropertyName("cutoffTime")]
        public virtual TimeSpan? CutoffTime { get; set; }

    /// <summary>
    /// ServicePeriod represents a duration with some constraints about cutoff time and business days. This is used e.g. in shipping for handling times or transit time.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    }
}
