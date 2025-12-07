using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    public partial class MusicRelease : MusicPlaylist
    {
        public MusicRelease()
        {
            Type = "MusicRelease";
        }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
        [JsonPropertyName("catalogNumber")]
        public virtual string? CatalogNumber { get; set; }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
        [JsonPropertyName("creditedTo")]
        public virtual object? CreditedTo { get; set; }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
        [JsonPropertyName("musicReleaseFormat")]
        public virtual MusicReleaseFormatType? MusicReleaseFormat { get; set; }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
        [JsonPropertyName("recordLabel")]
        public virtual Organization? RecordLabel { get; set; }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
        [JsonPropertyName("releaseOf")]
        public virtual MusicAlbum? ReleaseOf { get; set; }

    }
}
