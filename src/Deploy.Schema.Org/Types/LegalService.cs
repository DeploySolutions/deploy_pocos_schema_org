using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.\n\nAs a [[LocalBusiness]] it can be described as a [[provider]] of one or more [[Service]]\(s).
    /// </summary>
    public partial class LegalService : LocalBusiness
    {
        public LegalService()
        {
            Type = "LegalService";
        }

    }
}
