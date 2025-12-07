using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An application programming interface accessible over Web/Internet technologies.
    /// </summary>
    public partial class WebAPI : Service
    {
        public WebAPI()
        {
            Type = "WebAPI";
        }

    /// <summary>
    /// An application programming interface accessible over Web/Internet technologies.
    /// </summary>
        [JsonPropertyName("documentation")]
        public virtual object? Documentation { get; set; }

    }
}
