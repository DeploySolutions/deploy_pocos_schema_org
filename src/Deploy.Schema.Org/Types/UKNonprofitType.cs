using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// UKNonprofitType: Non-profit organization type originating from the United Kingdom.
    /// </summary>
    public partial class UKNonprofitType : NonprofitType
    {
        public UKNonprofitType()
        {
            Type = "UKNonprofitType";
        }

    }
}
