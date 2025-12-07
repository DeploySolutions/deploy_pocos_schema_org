using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A synagogue.
    /// </summary>
    public partial class Synagogue : PlaceOfWorship
    {
        public Synagogue()
        {
            Type = "Synagogue";
        }

    }
}
