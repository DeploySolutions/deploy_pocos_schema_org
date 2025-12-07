using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A car rental business.
    /// </summary>
    public partial class AutoRental : AutomotiveBusiness
    {
        public AutoRental()
        {
            Type = "AutoRental";
        }

    }
}
