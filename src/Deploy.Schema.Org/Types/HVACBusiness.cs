using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A business that provides Heating, Ventilation and Air Conditioning services.
    /// </summary>
    public partial class HVACBusiness : HomeAndConstructionBusiness
    {
        public HVACBusiness()
        {
            Type = "HVACBusiness";
        }

    }
}
