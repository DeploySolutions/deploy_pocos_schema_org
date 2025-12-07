using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    public partial class ChooseAction : AssessAction
    {
        public ChooseAction()
        {
            Type = "ChooseAction";
        }

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
        [JsonPropertyName("actionOption")]
        public virtual object? ActionOption { get; set; }

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
        [JsonPropertyName("option")]
        public virtual object? Option { get; set; }

    }
}
