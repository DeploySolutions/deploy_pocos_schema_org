using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
    public partial class Muscle : AnatomicalStructure
    {
        public Muscle()
        {
            Type = "Muscle";
        }

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
        [JsonPropertyName("antagonist")]
        public virtual Muscle? Antagonist { get; set; }

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
        [JsonPropertyName("bloodSupply")]
        public virtual Vessel? BloodSupply { get; set; }

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
        [JsonPropertyName("insertion")]
        public virtual AnatomicalStructure? Insertion { get; set; }

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
        [JsonPropertyName("muscleAction")]
        public virtual string? MuscleAction { get; set; }

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
        [JsonPropertyName("nerve")]
        public virtual Nerve? Nerve { get; set; }

    }
}
