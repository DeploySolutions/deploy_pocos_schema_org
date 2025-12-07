using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A class, also often called a 'Type'; equivalent to rdfs:Class.
    /// </summary>
    public partial class Class : Intangible
    {
        public Class()
        {
            Type = "Class";
        }

    /// <summary>
    /// A class, also often called a 'Type'; equivalent to rdfs:Class.
    /// </summary>
        [JsonPropertyName("supersededBy")]
        public virtual object? SupersededBy { get; set; }

    }
}
