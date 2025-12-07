using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    public partial class AssessAction : Action
    {
        public AssessAction()
        {
            Type = "AssessAction";
        }

    }
}
