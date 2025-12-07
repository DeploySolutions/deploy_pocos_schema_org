using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An image file.
    /// </summary>
    public partial class ImageObject : MediaObject
    {
        public ImageObject()
        {
            Type = "ImageObject";
        }

    /// <summary>
    /// An image file.
    /// </summary>
        [JsonPropertyName("caption")]
        public virtual object? Caption { get; set; }

    /// <summary>
    /// An image file.
    /// </summary>
        [JsonPropertyName("embeddedTextCaption")]
        public virtual string? EmbeddedTextCaption { get; set; }

    /// <summary>
    /// An image file.
    /// </summary>
        [JsonPropertyName("exifData")]
        public virtual object? ExifData { get; set; }

    /// <summary>
    /// An image file.
    /// </summary>
        [JsonPropertyName("representativeOfPage")]
        public virtual bool? RepresentativeOfPage { get; set; }

    }
}
