using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates a status for an incentive, such as whether it is active.
    /// </summary>
    public partial class IncentiveStatus : Enumeration
    {
        public IncentiveStatus()
        {
            Type = "IncentiveStatus";
        }

    }
}
