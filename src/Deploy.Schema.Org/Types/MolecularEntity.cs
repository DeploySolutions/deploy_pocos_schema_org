using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
    public partial class MolecularEntity : BioChemEntity
    {
        public MolecularEntity()
        {
            Type = "MolecularEntity";
        }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("chemicalRole")]
        public virtual DefinedTerm? ChemicalRole { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("inChI")]
        public virtual string? InChI { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("inChIKey")]
        public virtual string? InChIKey { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("iupacName")]
        public virtual string? IupacName { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("molecularFormula")]
        public virtual string? MolecularFormula { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("molecularWeight")]
        public virtual object? MolecularWeight { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("monoisotopicMolecularWeight")]
        public virtual object? MonoisotopicMolecularWeight { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("potentialUse")]
        public virtual DefinedTerm? PotentialUse { get; set; }

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// </summary>
        [JsonPropertyName("smiles")]
        public virtual string? Smiles { get; set; }

    }
}
