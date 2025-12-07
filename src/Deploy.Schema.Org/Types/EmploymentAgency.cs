using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An employment agency.
    /// </summary>
    public partial class EmploymentAgency : LocalBusiness
    {
        public EmploymentAgency()
        {
            Type = "EmploymentAgency";
        }

    }
}
