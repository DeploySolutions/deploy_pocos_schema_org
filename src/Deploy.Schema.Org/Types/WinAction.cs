using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    public partial class WinAction : AchieveAction
    {
        public WinAction()
        {
            Type = "WinAction";
        }

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
        [JsonPropertyName("loser")]
        public virtual Person? Loser { get; set; }

    }
}
