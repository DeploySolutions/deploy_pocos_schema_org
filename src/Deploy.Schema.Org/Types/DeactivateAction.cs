using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// </summary>
    public partial class DeactivateAction : ControlAction
    {
        public DeactivateAction()
        {
            Type = "DeactivateAction";
        }

    }
}
