using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A nail salon.
    /// </summary>
    public partial class NailSalon : HealthAndBeautyBusiness
    {
        public NailSalon()
        {
            Type = "NailSalon";
        }

    }
}
