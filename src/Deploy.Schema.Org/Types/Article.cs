using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
    public partial class Article : CreativeWork
    {
        public Article()
        {
            Type = "Article";
        }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("articleBody")]
        public virtual string? ArticleBody { get; set; }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("articleSection")]
        public virtual string? ArticleSection { get; set; }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("backstory")]
        public virtual object? Backstory { get; set; }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pageEnd")]
        public virtual object? PageEnd { get; set; }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pageStart")]
        public virtual object? PageStart { get; set; }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pagination")]
        public virtual string? Pagination { get; set; }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("speakable")]
        public virtual object? Speakable { get; set; }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("wordCount")]
        public virtual Integer? WordCount { get; set; }

    }
}
