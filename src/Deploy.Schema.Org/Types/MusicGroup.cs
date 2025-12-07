using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    public partial class MusicGroup : PerformingGroup
    {
        public MusicGroup()
        {
            Type = "MusicGroup";
        }

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
        [JsonPropertyName("album")]
        public virtual MusicAlbum? Album { get; set; }

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
        [JsonPropertyName("albums")]
        public virtual MusicAlbum? Albums { get; set; }

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
        [JsonPropertyName("genre")]
        public virtual object? Genre { get; set; }

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
        [JsonPropertyName("musicGroupMember")]
        public virtual Person? MusicGroupMember { get; set; }

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
        [JsonPropertyName("track")]
        public virtual object? Track { get; set; }

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
        [JsonPropertyName("tracks")]
        public virtual MusicRecording? Tracks { get; set; }

    }
}
