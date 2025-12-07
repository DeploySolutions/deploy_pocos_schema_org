using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A subscription which allows a user to access media including audio, video, books, etc.
    /// </summary>
    public partial class MediaSubscription : Intangible
    {
        public MediaSubscription()
        {
            Type = "MediaSubscription";
        }

    /// <summary>
    /// A subscription which allows a user to access media including audio, video, books, etc.
    /// </summary>
        [JsonPropertyName("authenticator")]
        public virtual Organization? Authenticator { get; set; }

    /// <summary>
    /// A subscription which allows a user to access media including audio, video, books, etc.
    /// </summary>
        [JsonPropertyName("expectsAcceptanceOf")]
        public virtual Offer? ExpectsAcceptanceOf { get; set; }

    }
}
