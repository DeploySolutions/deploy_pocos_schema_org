using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    public partial class MusicPlaylist : CreativeWork
    {
        public MusicPlaylist()
        {
            Type = "MusicPlaylist";
        }

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
        [JsonPropertyName("numTracks")]
        public virtual Integer? NumTracks { get; set; }

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
        [JsonPropertyName("track")]
        public virtual object? Track { get; set; }

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
        [JsonPropertyName("tracks")]
        public virtual MusicRecording? Tracks { get; set; }

    }
}
