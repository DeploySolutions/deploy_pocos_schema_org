using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A train station.
    /// </summary>
    public partial class TrainStation : CivicStructure
    {
        public TrainStation()
        {
            Type = "TrainStation";
        }

    }
}
