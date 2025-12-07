using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A hair salon.
    /// </summary>
    public partial class HairSalon : HealthAndBeautyBusiness
    {
        public HairSalon()
        {
            Type = "HairSalon";
        }

    }
}
