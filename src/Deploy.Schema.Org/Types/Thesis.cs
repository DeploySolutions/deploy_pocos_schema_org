using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    public partial class Thesis : CreativeWork
    {
        public Thesis()
        {
            Type = "Thesis";
        }

    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
        [JsonPropertyName("inSupportOf")]
        public virtual string? InSupportOf { get; set; }

    }
}
