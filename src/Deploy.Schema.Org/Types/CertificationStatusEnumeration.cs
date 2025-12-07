using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates the different statuses of a Certification (Active and Inactive).
    /// </summary>
    public partial class CertificationStatusEnumeration : Enumeration
    {
        public CertificationStatusEnumeration()
        {
            Type = "CertificationStatusEnumeration";
        }

    }
}
