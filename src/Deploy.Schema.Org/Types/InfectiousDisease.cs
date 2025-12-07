using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// </summary>
    public partial class InfectiousDisease : MedicalCondition
    {
        public InfectiousDisease()
        {
            Type = "InfectiousDisease";
        }

    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// </summary>
        [JsonPropertyName("infectiousAgent")]
        public virtual string? InfectiousAgent { get; set; }

    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// </summary>
        [JsonPropertyName("infectiousAgentClass")]
        public virtual InfectiousAgentClass? InfectiousAgentClass { get; set; }

    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// </summary>
        [JsonPropertyName("transmissionMethod")]
        public virtual string? TransmissionMethod { get; set; }

    }
}
