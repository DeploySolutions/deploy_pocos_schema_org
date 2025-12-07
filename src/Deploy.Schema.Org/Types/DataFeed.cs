using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// </summary>
    public partial class DataFeed : Dataset
    {
        public DataFeed()
        {
            Type = "DataFeed";
        }

    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// </summary>
        [JsonPropertyName("dataFeedElement")]
        public virtual object? DataFeedElement { get; set; }

    }
}
