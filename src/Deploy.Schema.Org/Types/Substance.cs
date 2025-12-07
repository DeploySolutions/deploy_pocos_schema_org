using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
    public partial class Substance : MedicalEntity
    {
        public Substance()
        {
            Type = "Substance";
        }

    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
        [JsonPropertyName("activeIngredient")]
        public virtual string? ActiveIngredient { get; set; }

    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
        [JsonPropertyName("maximumIntake")]
        public virtual MaximumDoseSchedule? MaximumIntake { get; set; }

    }
}
