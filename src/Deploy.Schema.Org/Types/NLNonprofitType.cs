using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// NLNonprofitType: Non-profit organization type originating from the Netherlands.
    /// </summary>
    public partial class NLNonprofitType : NonprofitType
    {
        public NLNonprofitType()
        {
            Type = "NLNonprofitType";
        }

    }
}
