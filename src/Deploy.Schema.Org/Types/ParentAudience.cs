using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
    public partial class ParentAudience : PeopleAudience
    {
        public ParentAudience()
        {
            Type = "ParentAudience";
        }

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
        [JsonPropertyName("childMaxAge")]
        public virtual double? ChildMaxAge { get; set; }

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// </summary>
        [JsonPropertyName("childMinAge")]
        public virtual double? ChildMinAge { get; set; }

    }
}
