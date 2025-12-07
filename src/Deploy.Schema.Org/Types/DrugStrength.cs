using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
    public partial class DrugStrength : MedicalIntangible
    {
        public DrugStrength()
        {
            Type = "DrugStrength";
        }

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
        [JsonPropertyName("activeIngredient")]
        public virtual string? ActiveIngredient { get; set; }

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
        [JsonPropertyName("availableIn")]
        public virtual AdministrativeArea? AvailableIn { get; set; }

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
        [JsonPropertyName("maximumIntake")]
        public virtual MaximumDoseSchedule? MaximumIntake { get; set; }

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
        [JsonPropertyName("strengthUnit")]
        public virtual string? StrengthUnit { get; set; }

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
        [JsonPropertyName("strengthValue")]
        public virtual double? StrengthValue { get; set; }

    }
}
