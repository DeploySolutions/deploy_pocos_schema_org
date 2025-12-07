using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    public partial class ReactAction : AssessAction
    {
        public ReactAction()
        {
            Type = "ReactAction";
        }

    }
}
