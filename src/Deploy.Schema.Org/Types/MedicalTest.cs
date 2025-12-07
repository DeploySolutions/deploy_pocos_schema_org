using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    public partial class MedicalTest : MedicalEntity
    {
        public MedicalTest()
        {
            Type = "MedicalTest";
        }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
        [JsonPropertyName("affectedBy")]
        public virtual Drug? AffectedBy { get; set; }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
        [JsonPropertyName("normalRange")]
        public virtual object? NormalRange { get; set; }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
        [JsonPropertyName("signDetected")]
        public virtual MedicalSign? SignDetected { get; set; }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
        [JsonPropertyName("usedToDiagnose")]
        public virtual MedicalCondition? UsedToDiagnose { get; set; }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
        [JsonPropertyName("usesDevice")]
        public virtual MedicalDevice? UsesDevice { get; set; }

    }
}
