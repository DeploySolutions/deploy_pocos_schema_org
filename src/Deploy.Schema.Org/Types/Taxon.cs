using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of organisms asserted to represent a natural cohesive biological unit.
    /// </summary>
    public partial class Taxon : Thing
    {
        public Taxon()
        {
            Type = "Taxon";
        }

    /// <summary>
    /// A set of organisms asserted to represent a natural cohesive biological unit.
    /// </summary>
        [JsonPropertyName("childTaxon")]
        public virtual object? ChildTaxon { get; set; }

    /// <summary>
    /// A set of organisms asserted to represent a natural cohesive biological unit.
    /// </summary>
        [JsonPropertyName("hasDefinedTerm")]
        public virtual DefinedTerm? HasDefinedTerm { get; set; }

    /// <summary>
    /// A set of organisms asserted to represent a natural cohesive biological unit.
    /// </summary>
        [JsonPropertyName("parentTaxon")]
        public virtual object? ParentTaxon { get; set; }

    /// <summary>
    /// A set of organisms asserted to represent a natural cohesive biological unit.
    /// </summary>
        [JsonPropertyName("taxonRank")]
        public virtual object? TaxonRank { get; set; }

    }
}
