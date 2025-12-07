using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of swallowing solid objects.
    /// </summary>
    public partial class EatAction : ConsumeAction
    {
        public EatAction()
        {
            Type = "EatAction";
        }

    }
}
