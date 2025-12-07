using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    public partial class Bone : AnatomicalStructure
    {
        public Bone()
        {
            Type = "Bone";
        }

    }
}
