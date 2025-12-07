using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent approves/certifies/likes/supports/sanctions an object.
    /// </summary>
    public partial class EndorseAction : ReactAction
    {
        public EndorseAction()
        {
            Type = "EndorseAction";
        }

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanctions an object.
    /// </summary>
        [JsonPropertyName("endorsee")]
        public virtual object? Endorsee { get; set; }

    }
}
