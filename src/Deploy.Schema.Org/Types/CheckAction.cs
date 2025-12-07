using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// </summary>
    public partial class CheckAction : FindAction
    {
        public CheckAction()
        {
            Type = "CheckAction";
        }

    }
}
