using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
    public partial class MedicalEntity : Thing
    {
        public MedicalEntity()
        {
            Type = "MedicalEntity";
        }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("code")]
        public virtual MedicalCode? Code { get; set; }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("funding")]
        public virtual Grant? Funding { get; set; }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("guideline")]
        public virtual MedicalGuideline? Guideline { get; set; }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("legalStatus")]
        public virtual object? LegalStatus { get; set; }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("medicineSystem")]
        public virtual MedicineSystem? MedicineSystem { get; set; }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("recognizingAuthority")]
        public virtual Organization? RecognizingAuthority { get; set; }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("relevantSpecialty")]
        public virtual MedicalSpecialty? RelevantSpecialty { get; set; }

    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// </summary>
        [JsonPropertyName("study")]
        public virtual MedicalStudy? Study { get; set; }

    }
}
