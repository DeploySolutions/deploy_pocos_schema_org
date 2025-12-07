using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// </summary>
    public partial class WebSite : CreativeWork
    {
        public WebSite()
        {
            Type = "WebSite";
        }

    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// </summary>
        [JsonPropertyName("issn")]
        public virtual string? Issn { get; set; }

    }
}
