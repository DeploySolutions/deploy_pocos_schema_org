using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// </summary>
    public partial class Mountain : Landform
    {
        public Mountain()
        {
            Type = "Mountain";
        }

    }
}
