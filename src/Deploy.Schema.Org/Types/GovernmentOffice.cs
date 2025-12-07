using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// </summary>
    public partial class GovernmentOffice : LocalBusiness
    {
        public GovernmentOffice()
        {
            Type = "GovernmentOffice";
        }

    }
}
