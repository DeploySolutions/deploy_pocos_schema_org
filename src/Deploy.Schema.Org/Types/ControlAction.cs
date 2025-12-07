using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    public partial class ControlAction : Action
    {
        public ControlAction()
        {
            Type = "ControlAction";
        }

    }
}
