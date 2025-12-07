using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A parking lot or other parking facility.
    /// </summary>
    public partial class ParkingFacility : CivicStructure
    {
        public ParkingFacility()
        {
            Type = "ParkingFacility";
        }

    }
}
