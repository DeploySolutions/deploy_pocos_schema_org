using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A gas station.
    /// </summary>
    public partial class GasStation : AutomotiveBusiness
    {
        public GasStation()
        {
            Type = "GasStation";
        }

    }
}
