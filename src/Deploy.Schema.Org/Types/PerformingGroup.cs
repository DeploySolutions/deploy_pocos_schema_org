using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// </summary>
    public partial class PerformingGroup : Organization
    {
        public PerformingGroup()
        {
            Type = "PerformingGroup";
        }

    }
}
