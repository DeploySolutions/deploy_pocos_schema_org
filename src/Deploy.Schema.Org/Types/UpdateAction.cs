using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    public partial class UpdateAction : Action
    {
        public UpdateAction()
        {
            Type = "UpdateAction";
        }

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
        [JsonPropertyName("collection")]
        public virtual Thing? Collection { get; set; }

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
        [JsonPropertyName("targetCollection")]
        public virtual Thing? TargetCollection { get; set; }

    }
}
