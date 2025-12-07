using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
    public partial class WebPage : CreativeWork
    {
        public WebPage()
        {
            Type = "WebPage";
        }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("breadcrumb")]
        public virtual object? Breadcrumb { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("lastReviewed")]
        public virtual DateTime? LastReviewed { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("mainContentOfPage")]
        public virtual WebPageElement? MainContentOfPage { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("primaryImageOfPage")]
        public virtual ImageObject? PrimaryImageOfPage { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("relatedLink")]
        public virtual string? RelatedLink { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("reviewedBy")]
        public virtual object? ReviewedBy { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("significantLink")]
        public virtual string? SignificantLink { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("significantLinks")]
        public virtual string? SignificantLinks { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("speakable")]
        public virtual object? Speakable { get; set; }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
        [JsonPropertyName("specialty")]
        public virtual Specialty? Specialty { get; set; }

    }
}
