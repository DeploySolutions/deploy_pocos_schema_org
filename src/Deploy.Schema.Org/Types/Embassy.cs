using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An embassy.
    /// </summary>
    public partial class Embassy : GovernmentBuilding
    {
        public Embassy()
        {
            Type = "Embassy";
        }

    }
}
