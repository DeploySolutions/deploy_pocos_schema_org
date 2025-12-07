using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [blog](https://en.wikipedia.org/wiki/Blog), sometimes known as a "weblog". Note that the individual posts ([[BlogPosting]]s) in a [[Blog]] are often colloquially referred to by the same term.
    /// </summary>
    public partial class Blog : CreativeWork
    {
        public Blog()
        {
            Type = "Blog";
        }

    /// <summary>
    /// A [blog](https://en.wikipedia.org/wiki/Blog), sometimes known as a "weblog". Note that the individual posts ([[BlogPosting]]s) in a [[Blog]] are often colloquially referred to by the same term.
    /// </summary>
        [JsonPropertyName("blogPost")]
        public virtual BlogPosting? BlogPost { get; set; }

    /// <summary>
    /// A [blog](https://en.wikipedia.org/wiki/Blog), sometimes known as a "weblog". Note that the individual posts ([[BlogPosting]]s) in a [[Blog]] are often colloquially referred to by the same term.
    /// </summary>
        [JsonPropertyName("blogPosts")]
        public virtual BlogPosting? BlogPosts { get; set; }

    /// <summary>
    /// A [blog](https://en.wikipedia.org/wiki/Blog), sometimes known as a "weblog". Note that the individual posts ([[BlogPosting]]s) in a [[Blog]] are often colloquially referred to by the same term.
    /// </summary>
        [JsonPropertyName("issn")]
        public virtual string? Issn { get; set; }

    }
}
