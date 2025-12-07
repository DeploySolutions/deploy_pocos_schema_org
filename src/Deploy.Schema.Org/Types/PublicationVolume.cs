using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
    public partial class PublicationVolume : CreativeWork
    {
        public PublicationVolume()
        {
            Type = "PublicationVolume";
        }

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pageEnd")]
        public virtual object? PageEnd { get; set; }

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pageStart")]
        public virtual object? PageStart { get; set; }

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("pagination")]
        public virtual string? Pagination { get; set; }

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// </summary>
        [JsonPropertyName("volumeNumber")]
        public virtual object? VolumeNumber { get; set; }

    }
}
