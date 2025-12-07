using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    public partial class Nerve : AnatomicalStructure
    {
        public Nerve()
        {
            Type = "Nerve";
        }

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
        [JsonPropertyName("branch")]
        public virtual AnatomicalStructure? Branch { get; set; }

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
        [JsonPropertyName("nerveMotor")]
        public virtual Muscle? NerveMotor { get; set; }

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
        [JsonPropertyName("sensoryUnit")]
        public virtual object? SensoryUnit { get; set; }

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
        [JsonPropertyName("sourcedFrom")]
        public virtual BrainStructure? SourcedFrom { get; set; }

    }
}
