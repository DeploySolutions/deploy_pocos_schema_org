using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    public partial class IgnoreAction : AssessAction
    {
        public IgnoreAction()
        {
            Type = "IgnoreAction";
        }

    }
}
