using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An enumeration of possible benefits as part of a loyalty (members) program.
    /// </summary>
    public partial class TierBenefitEnumeration : Enumeration
    {
        public TierBenefitEnumeration()
        {
            Type = "TierBenefitEnumeration";
        }

    }
}
