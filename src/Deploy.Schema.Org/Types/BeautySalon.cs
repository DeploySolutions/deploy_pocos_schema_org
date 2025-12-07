using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Beauty salon.
    /// </summary>
    public partial class BeautySalon : HealthAndBeautyBusiness
    {
        public BeautySalon()
        {
            Type = "BeautySalon";
        }

    }
}
