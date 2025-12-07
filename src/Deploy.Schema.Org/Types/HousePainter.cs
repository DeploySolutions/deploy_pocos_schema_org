using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A house painting service.
    /// </summary>
    public partial class HousePainter : HomeAndConstructionBusiness
    {
        public HousePainter()
        {
            Type = "HousePainter";
        }

    }
}
