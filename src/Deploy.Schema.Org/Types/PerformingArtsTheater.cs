using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A theater or other performing art center.
    /// </summary>
    public partial class PerformingArtsTheater : CivicStructure
    {
        public PerformingArtsTheater()
        {
            Type = "PerformingArtsTheater";
        }

    }
}
