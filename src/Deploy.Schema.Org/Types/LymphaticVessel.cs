using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
    public partial class LymphaticVessel : Vessel
    {
        public LymphaticVessel()
        {
            Type = "LymphaticVessel";
        }

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
        [JsonPropertyName("originatesFrom")]
        public virtual Vessel? OriginatesFrom { get; set; }

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
        [JsonPropertyName("regionDrained")]
        public virtual object? RegionDrained { get; set; }

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
        [JsonPropertyName("runsTo")]
        public virtual Vessel? RunsTo { get; set; }

    }
}
