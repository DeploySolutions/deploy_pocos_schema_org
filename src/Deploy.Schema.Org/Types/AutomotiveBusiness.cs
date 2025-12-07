using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Car repair, sales, or parts.
    /// </summary>
    public partial class AutomotiveBusiness : LocalBusiness
    {
        public AutomotiveBusiness()
        {
            Type = "AutomotiveBusiness";
        }

    }
}
