using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any anatomical structure which pertains to the soft nervous tissue functioning as the coordinating center of sensation and intellectual and nervous activity.
    /// </summary>
    public partial class BrainStructure : AnatomicalStructure
    {
        public BrainStructure()
        {
            Type = "BrainStructure";
        }

    }
}
