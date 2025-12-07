using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumeration of considerations that make a product relevant or potentially restricted for adults only.
    /// </summary>
    public partial class AdultOrientedEnumeration : Enumeration
    {
        public AdultOrientedEnumeration()
        {
            Type = "AdultOrientedEnumeration";
        }

    }
}
