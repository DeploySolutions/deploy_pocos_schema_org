using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    public partial class DataFeedItem : Intangible
    {
        public DataFeedItem()
        {
            Type = "DataFeedItem";
        }

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
        [JsonPropertyName("dateCreated")]
        public virtual object? DateCreated { get; set; }

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
        [JsonPropertyName("dateDeleted")]
        public virtual object? DateDeleted { get; set; }

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
        [JsonPropertyName("dateModified")]
        public virtual object? DateModified { get; set; }

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
        [JsonPropertyName("item")]
        public virtual Thing? Item { get; set; }

    }
}
