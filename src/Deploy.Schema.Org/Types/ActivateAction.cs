using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    /// </summary>
    public partial class ActivateAction : ControlAction
    {
        public ActivateAction()
        {
            Type = "ActivateAction";
        }

    }
}
