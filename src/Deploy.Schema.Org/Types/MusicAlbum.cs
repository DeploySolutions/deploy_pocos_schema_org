using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    public partial class MusicAlbum : MusicPlaylist
    {
        public MusicAlbum()
        {
            Type = "MusicAlbum";
        }

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
        [JsonPropertyName("albumProductionType")]
        public virtual MusicAlbumProductionType? AlbumProductionType { get; set; }

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
        [JsonPropertyName("albumRelease")]
        public virtual MusicRelease? AlbumRelease { get; set; }

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
        [JsonPropertyName("albumReleaseType")]
        public virtual MusicAlbumReleaseType? AlbumReleaseType { get; set; }

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
        [JsonPropertyName("byArtist")]
        public virtual object? ByArtist { get; set; }

    }
}
