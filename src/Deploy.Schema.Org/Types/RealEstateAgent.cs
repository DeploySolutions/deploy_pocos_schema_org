using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A real-estate agent.
    /// </summary>
    public partial class RealEstateAgent : LocalBusiness
    {
        public RealEstateAgent()
        {
            Type = "RealEstateAgent";
        }

    }
}
