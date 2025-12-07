using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    public partial class GovernmentOrganization : Organization
    {
        public GovernmentOrganization()
        {
            Type = "GovernmentOrganization";
        }

    }
}
