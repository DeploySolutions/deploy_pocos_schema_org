using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Lists or enumerations—for example, a list of cuisines or music genres, etc.
    /// </summary>
    public partial class Enumeration : Intangible
    {
        public Enumeration()
        {
            Type = "Enumeration";
        }

    /// <summary>
    /// Lists or enumerations—for example, a list of cuisines or music genres, etc.
    /// </summary>
        [JsonPropertyName("supersededBy")]
        public virtual object? SupersededBy { get; set; }

    }
}
