using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A ski resort.
    /// </summary>
    public partial class SkiResort : Resort
    {
        public SkiResort()
        {
            Type = "SkiResort";
        }

    }
}
