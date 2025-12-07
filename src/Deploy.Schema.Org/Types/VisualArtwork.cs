using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    public partial class VisualArtwork : CreativeWork
    {
        public VisualArtwork()
        {
            Type = "VisualArtwork";
        }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("artEdition")]
        public virtual object? ArtEdition { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("artform")]
        public virtual object? Artform { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("artist")]
        public virtual Person? Artist { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("artMedium")]
        public virtual object? ArtMedium { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("artworkSurface")]
        public virtual object? ArtworkSurface { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("colorist")]
        public virtual Person? Colorist { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("depth")]
        public virtual object? Depth { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("height")]
        public virtual object? Height { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("inker")]
        public virtual Person? Inker { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("letterer")]
        public virtual Person? Letterer { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("penciler")]
        public virtual Person? Penciler { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("surface")]
        public virtual object? Surface { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("weight")]
        public virtual object? Weight { get; set; }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
        [JsonPropertyName("width")]
        public virtual object? Width { get; set; }

    }
}
