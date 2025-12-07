using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of defined terms, for example a set of categories or a classification scheme, a glossary, dictionary or enumeration.
    /// </summary>
    public partial class DefinedTermSet : CreativeWork
    {
        public DefinedTermSet()
        {
            Type = "DefinedTermSet";
        }

    /// <summary>
    /// A set of defined terms, for example a set of categories or a classification scheme, a glossary, dictionary or enumeration.
    /// </summary>
        [JsonPropertyName("hasDefinedTerm")]
        public virtual DefinedTerm? HasDefinedTerm { get; set; }

    }
}
