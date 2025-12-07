using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// This is the [[Action]] of navigating to a specific [[startOffset]] timestamp within a [[VideoObject]], typically represented with a URL template structure.
    /// </summary>
    public partial class SeekToAction : Action
    {
        public SeekToAction()
        {
            Type = "SeekToAction";
        }

    /// <summary>
    /// This is the [[Action]] of navigating to a specific [[startOffset]] timestamp within a [[VideoObject]], typically represented with a URL template structure.
    /// </summary>
        [JsonPropertyName("startOffset")]
        public virtual object? StartOffset { get; set; }

    }
}
