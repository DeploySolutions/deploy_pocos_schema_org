using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A mosque.
    /// </summary>
    public partial class Mosque : PlaceOfWorship
    {
        public Mosque()
        {
            Type = "Mosque";
        }

    }
}
