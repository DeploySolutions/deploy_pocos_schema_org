using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// USNonprofitType: Non-profit organization type originating from the United States.
    /// </summary>
    public partial class USNonprofitType : NonprofitType
    {
        public USNonprofitType()
        {
            Type = "USNonprofitType";
        }

    }
}
