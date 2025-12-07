using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A car wash business.
    /// </summary>
    public partial class AutoWash : AutomotiveBusiness
    {
        public AutoWash()
        {
            Type = "AutoWash";
        }

    }
}
