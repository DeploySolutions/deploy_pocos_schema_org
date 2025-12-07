using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A specific object or file containing a Legislation. Note that the same Legislation can be published in multiple files. For example, a digitally signed PDF, a plain PDF and an HTML version.
    /// </summary>
    public partial class LegislationObject : Legislation
    {
        public LegislationObject()
        {
            Type = "LegislationObject";
        }

    /// <summary>
    /// A specific object or file containing a Legislation. Note that the same Legislation can be published in multiple files. For example, a digitally signed PDF, a plain PDF and an HTML version.
    /// </summary>
        [JsonPropertyName("legislationLegalValue")]
        public virtual LegalValueLevel? LegislationLegalValue { get; set; }

    }
}
