using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A city hall.
    /// </summary>
    public partial class CityHall : GovernmentBuilding
    {
        public CityHall()
        {
            Type = "CityHall";
        }

    }
}
