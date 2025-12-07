using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    public partial class MusicRecording : CreativeWork
    {
        public MusicRecording()
        {
            Type = "MusicRecording";
        }

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
        [JsonPropertyName("byArtist")]
        public virtual object? ByArtist { get; set; }

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
        [JsonPropertyName("duration")]
        public virtual object? Duration { get; set; }

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
        [JsonPropertyName("inAlbum")]
        public virtual MusicAlbum? InAlbum { get; set; }

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
        [JsonPropertyName("inPlaylist")]
        public virtual MusicPlaylist? InPlaylist { get; set; }

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
        [JsonPropertyName("isrcCode")]
        public virtual string? IsrcCode { get; set; }

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
        [JsonPropertyName("recordingOf")]
        public virtual MusicComposition? RecordingOf { get; set; }

    }
}
