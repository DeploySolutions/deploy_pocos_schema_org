using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// GovernmentBenefitsType enumerates several kinds of government benefits to support the COVID-19 situation. Note that this structure may not capture all benefits offered.
    /// </summary>
    public partial class GovernmentBenefitsType : Enumeration
    {
        public GovernmentBenefitsType()
        {
            Type = "GovernmentBenefitsType";
        }

    }
}
