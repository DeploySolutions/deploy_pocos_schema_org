using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A day spa.
    /// </summary>
    public partial class DaySpa : HealthAndBeautyBusiness
    {
        public DaySpa()
        {
            Type = "DaySpa";
        }

    }
}
