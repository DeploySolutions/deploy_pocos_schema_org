using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// </summary>
    public partial class UseAction : ConsumeAction
    {
        public UseAction()
        {
            Type = "UseAction";
        }

    }
}
