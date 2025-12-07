using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A chemical substance is 'a portion of matter of constant composition, composed of molecular entities of the same type or of different types' (source: [ChEBI:59999](https://www.ebi.ac.uk/chebi/searchId.do?chebiId=59999)).
    /// </summary>
    public partial class ChemicalSubstance : BioChemEntity
    {
        public ChemicalSubstance()
        {
            Type = "ChemicalSubstance";
        }

    /// <summary>
    /// A chemical substance is 'a portion of matter of constant composition, composed of molecular entities of the same type or of different types' (source: [ChEBI:59999](https://www.ebi.ac.uk/chebi/searchId.do?chebiId=59999)).
    /// </summary>
        [JsonPropertyName("chemicalComposition")]
        public virtual string? ChemicalComposition { get; set; }

    /// <summary>
    /// A chemical substance is 'a portion of matter of constant composition, composed of molecular entities of the same type or of different types' (source: [ChEBI:59999](https://www.ebi.ac.uk/chebi/searchId.do?chebiId=59999)).
    /// </summary>
        [JsonPropertyName("chemicalRole")]
        public virtual DefinedTerm? ChemicalRole { get; set; }

    /// <summary>
    /// A chemical substance is 'a portion of matter of constant composition, composed of molecular entities of the same type or of different types' (source: [ChEBI:59999](https://www.ebi.ac.uk/chebi/searchId.do?chebiId=59999)).
    /// </summary>
        [JsonPropertyName("potentialUse")]
        public virtual DefinedTerm? PotentialUse { get; set; }

    }
}
