using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    public partial class PathologyTest : MedicalTest
    {
        public PathologyTest()
        {
            Type = "PathologyTest";
        }

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
        [JsonPropertyName("tissueSample")]
        public virtual string? TissueSample { get; set; }

    }
}
