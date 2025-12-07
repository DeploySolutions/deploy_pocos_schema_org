using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// </summary>
    public partial class CableOrSatelliteService : Service
    {
        public CableOrSatelliteService()
        {
            Type = "CableOrSatelliteService";
        }

    }
}
