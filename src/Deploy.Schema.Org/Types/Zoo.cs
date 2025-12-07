using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A zoo.
    /// </summary>
    public partial class Zoo : CivicStructure
    {
        public Zoo()
        {
            Type = "Zoo";
        }

    }
}
