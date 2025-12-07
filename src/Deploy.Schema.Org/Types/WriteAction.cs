using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of authoring written creative content.
    /// </summary>
    public partial class WriteAction : CreateAction
    {
        public WriteAction()
        {
            Type = "WriteAction";
        }

    /// <summary>
    /// The act of authoring written creative content.
    /// </summary>
        [JsonPropertyName("inLanguage")]
        public virtual object? InLanguage { get; set; }

    /// <summary>
    /// The act of authoring written creative content.
    /// </summary>
        [JsonPropertyName("language")]
        public virtual Language? Language { get; set; }

    }
}
