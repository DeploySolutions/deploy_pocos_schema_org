using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// </summary>
    public partial class DanceGroup : PerformingGroup
    {
        public DanceGroup()
        {
            Type = "DanceGroup";
        }

    }
}
