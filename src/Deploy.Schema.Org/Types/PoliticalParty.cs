using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Organization: Political Party.
    /// </summary>
    public partial class PoliticalParty : Organization
    {
        public PoliticalParty()
        {
            Type = "PoliticalParty";
        }

    }
}
