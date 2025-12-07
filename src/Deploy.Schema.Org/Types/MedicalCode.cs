using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A code for a medical entity.
    /// </summary>
    public partial class MedicalCode : CategoryCode
    {
        public MedicalCode()
        {
            Type = "MedicalCode";
        }

    /// <summary>
    /// A code for a medical entity.
    /// </summary>
        [JsonPropertyName("codeValue")]
        public virtual string? CodeValue { get; set; }

    /// <summary>
    /// A code for a medical entity.
    /// </summary>
        [JsonPropertyName("codingSystem")]
        public virtual string? CodingSystem { get; set; }

    }
}
