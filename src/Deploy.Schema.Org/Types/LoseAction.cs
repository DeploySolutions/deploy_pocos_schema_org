using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    public partial class LoseAction : AchieveAction
    {
        public LoseAction()
        {
            Type = "LoseAction";
        }

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
        [JsonPropertyName("winner")]
        public virtual Person? Winner { get; set; }

    }
}
