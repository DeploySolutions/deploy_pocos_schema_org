using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// </summary>
    public partial class TheaterGroup : PerformingGroup
    {
        public TheaterGroup()
        {
            Type = "TheaterGroup";
        }

    }
}
