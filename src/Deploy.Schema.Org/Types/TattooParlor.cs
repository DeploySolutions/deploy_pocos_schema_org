using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A tattoo parlor.
    /// </summary>
    public partial class TattooParlor : HealthAndBeautyBusiness
    {
        public TattooParlor()
        {
            Type = "TattooParlor";
        }

    }
}
