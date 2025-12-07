using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// </summary>
    public partial class ResumeAction : ControlAction
    {
        public ResumeAction()
        {
            Type = "ResumeAction";
        }

    }
}
