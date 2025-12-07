using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
    public partial class BioChemEntity : Thing
    {
        public BioChemEntity()
        {
            Type = "BioChemEntity";
        }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("associatedDisease")]
        public virtual object? AssociatedDisease { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("bioChemInteraction")]
        public virtual BioChemEntity? BioChemInteraction { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("bioChemSimilarity")]
        public virtual BioChemEntity? BioChemSimilarity { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("biologicalRole")]
        public virtual DefinedTerm? BiologicalRole { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("funding")]
        public virtual Grant? Funding { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("hasBioChemEntityPart")]
        public virtual BioChemEntity? HasBioChemEntityPart { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("hasMolecularFunction")]
        public virtual object? HasMolecularFunction { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("hasRepresentation")]
        public virtual object? HasRepresentation { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("isEncodedByBioChemEntity")]
        public virtual Gene? IsEncodedByBioChemEntity { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("isInvolvedInBiologicalProcess")]
        public virtual object? IsInvolvedInBiologicalProcess { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("isLocatedInSubcellularLocation")]
        public virtual object? IsLocatedInSubcellularLocation { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("isPartOfBioChemEntity")]
        public virtual BioChemEntity? IsPartOfBioChemEntity { get; set; }

    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// </summary>
        [JsonPropertyName("taxonomicRange")]
        public virtual object? TaxonomicRange { get; set; }

    }
}
