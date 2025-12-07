using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
    public partial class VoteAction : ChooseAction
    {
        public VoteAction()
        {
            Type = "VoteAction";
        }

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
        [JsonPropertyName("candidate")]
        public virtual Person? Candidate { get; set; }

    }
}
