using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A crematorium.
    /// </summary>
    public partial class Crematorium : CivicStructure
    {
        public Crematorium()
        {
            Type = "Crematorium";
        }

    }
}
