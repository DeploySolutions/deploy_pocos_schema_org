using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// </summary>
    public partial class SuspendAction : ControlAction
    {
        public SuspendAction()
        {
            Type = "SuspendAction";
        }

    }
}
