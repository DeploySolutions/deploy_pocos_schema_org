using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
    /// A more detailed overview of [schema.org News markup](/docs/news.html) is also available.
    /// </summary>
    public partial class NewsArticle : Article
    {
        public NewsArticle()
        {
            Type = "NewsArticle";
        }

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
    /// A more detailed overview of [schema.org News markup](/docs/news.html) is also available.
    /// </summary>
        [JsonPropertyName("dateline")]
        public virtual string? Dateline { get; set; }

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
    /// A more detailed overview of [schema.org News markup](/docs/news.html) is also available.
    /// </summary>
        [JsonPropertyName("printColumn")]
        public virtual string? PrintColumn { get; set; }

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
    /// A more detailed overview of [schema.org News markup](/docs/news.html) is also available.
    /// </summary>
        [JsonPropertyName("printEdition")]
        public virtual string? PrintEdition { get; set; }

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
    /// A more detailed overview of [schema.org News markup](/docs/news.html) is also available.
    /// </summary>
        [JsonPropertyName("printPage")]
        public virtual string? PrintPage { get; set; }

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
    /// A more detailed overview of [schema.org News markup](/docs/news.html) is also available.
    /// </summary>
        [JsonPropertyName("printSection")]
        public virtual string? PrintSection { get; set; }

    }
}
