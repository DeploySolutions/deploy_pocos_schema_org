using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web applications.
    /// </summary>
    public partial class WebApplication : SoftwareApplication
    {
        public WebApplication()
        {
            Type = "WebApplication";
        }

    /// <summary>
    /// Web applications.
    /// </summary>
        [JsonPropertyName("browserRequirements")]
        public virtual string? BrowserRequirements { get; set; }

    }
}
