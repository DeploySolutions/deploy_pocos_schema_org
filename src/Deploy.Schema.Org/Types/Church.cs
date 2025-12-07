using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A church.
    /// </summary>
    public partial class Church : PlaceOfWorship
    {
        public Church()
        {
            Type = "Church";
        }

    }
}
