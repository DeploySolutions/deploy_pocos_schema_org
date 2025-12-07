using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// </summary>
    public partial class TaxiService : Service
    {
        public TaxiService()
        {
            Type = "TaxiService";
        }

    }
}
