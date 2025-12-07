using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Car repair business.
    /// </summary>
    public partial class AutoRepair : AutomotiveBusiness
    {
        public AutoRepair()
        {
            Type = "AutoRepair";
        }

    }
}
