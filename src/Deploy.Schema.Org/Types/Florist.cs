using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A florist.
    /// </summary>
    public partial class Florist : Store
    {
        public Florist()
        {
            Type = "Florist";
        }

    }
}
