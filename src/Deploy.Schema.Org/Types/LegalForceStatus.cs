using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A list of possible statuses for the legal force of a legislation.
    /// </summary>
    public partial class LegalForceStatus : StatusEnumeration
    {
        public LegalForceStatus()
        {
            Type = "LegalForceStatus";
        }

    }
}
