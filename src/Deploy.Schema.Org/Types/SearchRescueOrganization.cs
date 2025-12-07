using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Search and Rescue organization of some kind.
    /// </summary>
    public partial class SearchRescueOrganization : Organization
    {
        public SearchRescueOrganization()
        {
            Type = "SearchRescueOrganization";
        }

    }
}
