using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A courthouse.
    /// </summary>
    public partial class Courthouse : GovernmentBuilding
    {
        public Courthouse()
        {
            Type = "Courthouse";
        }

    }
}
