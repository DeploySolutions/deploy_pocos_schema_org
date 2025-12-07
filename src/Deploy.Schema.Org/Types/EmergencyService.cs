using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    public partial class EmergencyService : LocalBusiness
    {
        public EmergencyService()
        {
            Type = "EmergencyService";
        }

    }
}
