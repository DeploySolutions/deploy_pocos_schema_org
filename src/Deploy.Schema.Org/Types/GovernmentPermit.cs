using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A permit issued by a government agency.
    /// </summary>
    public partial class GovernmentPermit : Permit
    {
        public GovernmentPermit()
        {
            Type = "GovernmentPermit";
        }

    }
}
