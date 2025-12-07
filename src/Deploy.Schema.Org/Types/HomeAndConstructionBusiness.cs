using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A construction business.\n\nA HomeAndConstructionBusiness is a [[LocalBusiness]] that provides services around homes and buildings.\n\nAs a [[LocalBusiness]] it can be described as a [[provider]] of one or more [[Service]]\(s).
    /// </summary>
    public partial class HomeAndConstructionBusiness : LocalBusiness
    {
        public HomeAndConstructionBusiness()
        {
            Type = "HomeAndConstructionBusiness";
        }

    }
}
