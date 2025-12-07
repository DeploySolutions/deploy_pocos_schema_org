using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
    public partial class MedicalScholarlyArticle : ScholarlyArticle
    {
        public MedicalScholarlyArticle()
        {
            Type = "MedicalScholarlyArticle";
        }

    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
        [JsonPropertyName("publicationType")]
        public virtual string? PublicationType { get; set; }

    }
}
