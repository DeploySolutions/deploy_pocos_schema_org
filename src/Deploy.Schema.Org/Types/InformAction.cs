using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// </summary>
    public partial class InformAction : CommunicateAction
    {
        public InformAction()
        {
            Type = "InformAction";
        }

    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// </summary>
        [JsonPropertyName("event")]
        public virtual Event? Event { get; set; }

    }
}
