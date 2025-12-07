using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A discrete unit of inheritance which affects one or more biological traits (Source: [https://en.wikipedia.org/wiki/Gene](https://en.wikipedia.org/wiki/Gene)). Examples include FOXP2 (Forkhead box protein P2), SCARNA21 (small Cajal body-specific RNA 21), A- (agouti genotype).
    /// </summary>
    public partial class Gene : BioChemEntity
    {
        public Gene()
        {
            Type = "Gene";
        }

    /// <summary>
    /// A discrete unit of inheritance which affects one or more biological traits (Source: [https://en.wikipedia.org/wiki/Gene](https://en.wikipedia.org/wiki/Gene)). Examples include FOXP2 (Forkhead box protein P2), SCARNA21 (small Cajal body-specific RNA 21), A- (agouti genotype).
    /// </summary>
        [JsonPropertyName("alternativeOf")]
        public virtual Gene? AlternativeOf { get; set; }

    /// <summary>
    /// A discrete unit of inheritance which affects one or more biological traits (Source: [https://en.wikipedia.org/wiki/Gene](https://en.wikipedia.org/wiki/Gene)). Examples include FOXP2 (Forkhead box protein P2), SCARNA21 (small Cajal body-specific RNA 21), A- (agouti genotype).
    /// </summary>
        [JsonPropertyName("encodesBioChemEntity")]
        public virtual BioChemEntity? EncodesBioChemEntity { get; set; }

    /// <summary>
    /// A discrete unit of inheritance which affects one or more biological traits (Source: [https://en.wikipedia.org/wiki/Gene](https://en.wikipedia.org/wiki/Gene)). Examples include FOXP2 (Forkhead box protein P2), SCARNA21 (small Cajal body-specific RNA 21), A- (agouti genotype).
    /// </summary>
        [JsonPropertyName("expressedIn")]
        public virtual object? ExpressedIn { get; set; }

    /// <summary>
    /// A discrete unit of inheritance which affects one or more biological traits (Source: [https://en.wikipedia.org/wiki/Gene](https://en.wikipedia.org/wiki/Gene)). Examples include FOXP2 (Forkhead box protein P2), SCARNA21 (small Cajal body-specific RNA 21), A- (agouti genotype).
    /// </summary>
        [JsonPropertyName("hasBioPolymerSequence")]
        public virtual string? HasBioPolymerSequence { get; set; }

    }
}
