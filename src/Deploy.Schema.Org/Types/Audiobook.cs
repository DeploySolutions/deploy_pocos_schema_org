using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An audiobook.
    /// </summary>
    public partial class Audiobook : Book
    {
        public Audiobook()
        {
            Type = "Audiobook";
        }

    /// <summary>
    /// An audiobook.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// An audiobook.
    /// </summary>
        [JsonPropertyName("readBy")]
        public virtual Person? ReadBy { get; set; }

    }
}
