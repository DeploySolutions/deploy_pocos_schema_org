using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    public partial class WebPageElement : CreativeWork
    {
        public WebPageElement()
        {
            Type = "WebPageElement";
        }

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
        [JsonPropertyName("cssSelector")]
        public virtual CssSelectorType? CssSelector { get; set; }

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
        [JsonPropertyName("xpath")]
        public virtual XPathType? Xpath { get; set; }

    }
}
