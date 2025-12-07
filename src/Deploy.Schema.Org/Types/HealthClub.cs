using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A health club.
    /// </summary>
    public partial class HealthClub : HealthAndBeautyBusiness
    {
        public HealthClub()
        {
            Type = "HealthClub";
        }

    }
}
