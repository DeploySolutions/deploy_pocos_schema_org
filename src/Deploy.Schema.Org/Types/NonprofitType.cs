using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// NonprofitType enumerates several kinds of official non-profit types of which a non-profit organization can be.
    /// </summary>
    public partial class NonprofitType : Enumeration
    {
        public NonprofitType()
        {
            Type = "NonprofitType";
        }

    }
}
