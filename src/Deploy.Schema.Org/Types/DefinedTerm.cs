using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A word, name, acronym, phrase, etc. with a formal definition. Often used in the context of category or subject classification, glossaries or dictionaries, product or creative work types, etc. Use the name property for the term being defined, use termCode if the term has an alpha-numeric code allocated, use description to provide the definition of the term.
    /// </summary>
    public partial class DefinedTerm : Intangible
    {
        public DefinedTerm()
        {
            Type = "DefinedTerm";
        }

    /// <summary>
    /// A word, name, acronym, phrase, etc. with a formal definition. Often used in the context of category or subject classification, glossaries or dictionaries, product or creative work types, etc. Use the name property for the term being defined, use termCode if the term has an alpha-numeric code allocated, use description to provide the definition of the term.
    /// </summary>
        [JsonPropertyName("inDefinedTermSet")]
        public virtual object? InDefinedTermSet { get; set; }

    /// <summary>
    /// A word, name, acronym, phrase, etc. with a formal definition. Often used in the context of category or subject classification, glossaries or dictionaries, product or creative work types, etc. Use the name property for the term being defined, use termCode if the term has an alpha-numeric code allocated, use description to provide the definition of the term.
    /// </summary>
        [JsonPropertyName("termCode")]
        public virtual string? TermCode { get; set; }

    }
}
