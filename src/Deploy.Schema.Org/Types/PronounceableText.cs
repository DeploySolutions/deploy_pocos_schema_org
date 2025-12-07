using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Data type: PronounceableText.
    /// </summary>
    public partial class PronounceableText : SchemaObject
    {
        public PronounceableText()
        {
            Type = "PronounceableText";
        }

    /// <summary>
    /// Data type: PronounceableText.
    /// </summary>
        [JsonPropertyName("inLanguage")]
        public virtual object? InLanguage { get; set; }

    /// <summary>
    /// Data type: PronounceableText.
    /// </summary>
        [JsonPropertyName("phoneticText")]
        public virtual string? PhoneticText { get; set; }

    /// <summary>
    /// Data type: PronounceableText.
    /// </summary>
        [JsonPropertyName("speechToTextMarkup")]
        public virtual string? SpeechToTextMarkup { get; set; }

    /// <summary>
    /// Data type: PronounceableText.
    /// </summary>
        [JsonPropertyName("textValue")]
        public virtual string? TextValue { get; set; }

    }
}
