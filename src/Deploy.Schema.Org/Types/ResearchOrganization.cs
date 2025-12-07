using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Research Organization (e.g. scientific institute, research company).
    /// </summary>
    public partial class ResearchOrganization : Organization
    {
        public ResearchOrganization()
        {
            Type = "ResearchOrganization";
        }

    }
}
