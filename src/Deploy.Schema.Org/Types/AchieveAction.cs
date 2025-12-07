using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// </summary>
    public partial class AchieveAction : Action
    {
        public AchieveAction()
        {
            Type = "AchieveAction";
        }

    }
}
