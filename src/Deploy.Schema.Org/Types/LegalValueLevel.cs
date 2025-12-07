using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A list of possible levels for the legal validity of a legislation.
    /// </summary>
    public partial class LegalValueLevel : Enumeration
    {
        public LegalValueLevel()
        {
            Type = "LegalValueLevel";
        }

    }
}
