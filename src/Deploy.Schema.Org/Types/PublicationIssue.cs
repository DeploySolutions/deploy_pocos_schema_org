using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
    public partial class PublicationIssue : CreativeWork
    {
        public PublicationIssue()
        {
            Type = "PublicationIssue";
        }

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("issueNumber")]
        public virtual object? IssueNumber { get; set; }

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pageEnd")]
        public virtual object? PageEnd { get; set; }

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pageStart")]
        public virtual object? PageStart { get; set; }

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pagination")]
        public virtual string? Pagination { get; set; }

    }
}
