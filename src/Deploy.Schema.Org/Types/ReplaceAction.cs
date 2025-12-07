using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    public partial class ReplaceAction : UpdateAction
    {
        public ReplaceAction()
        {
            Type = "ReplaceAction";
        }

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
        [JsonPropertyName("replacee")]
        public virtual Thing? Replacee { get; set; }

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
        [JsonPropertyName("replacer")]
        public virtual Thing? Replacer { get; set; }

    }
}
