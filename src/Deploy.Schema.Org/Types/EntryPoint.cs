using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
    public partial class EntryPoint : Intangible
    {
        public EntryPoint()
        {
            Type = "EntryPoint";
        }

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
        [JsonPropertyName("actionApplication")]
        public virtual SoftwareApplication? ActionApplication { get; set; }

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
        [JsonPropertyName("actionPlatform")]
        public virtual object? ActionPlatform { get; set; }

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
        [JsonPropertyName("application")]
        public virtual SoftwareApplication? Application { get; set; }

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
        [JsonPropertyName("contentType")]
        public virtual string? ContentType { get; set; }

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
        [JsonPropertyName("encodingType")]
        public virtual string? EncodingType { get; set; }

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
        [JsonPropertyName("httpMethod")]
        public virtual string? HttpMethod { get; set; }

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
        [JsonPropertyName("urlTemplate")]
        public virtual string? UrlTemplate { get; set; }

    }
}
