using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A police station.
    /// </summary>
    public partial class PoliceStation : CivicStructure
    {
        public PoliceStation()
        {
            Type = "PoliceStation";
        }

    }
}
