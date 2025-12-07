using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Aquarium.
    /// </summary>
    public partial class Aquarium : CivicStructure
    {
        public Aquarium()
        {
            Type = "Aquarium";
        }

    }
}
