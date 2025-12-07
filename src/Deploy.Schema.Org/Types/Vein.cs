using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
    public partial class Vein : Vessel
    {
        public Vein()
        {
            Type = "Vein";
        }

    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
        [JsonPropertyName("drainsTo")]
        public virtual Vessel? DrainsTo { get; set; }

    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
        [JsonPropertyName("regionDrained")]
        public virtual object? RegionDrained { get; set; }

    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
        [JsonPropertyName("tributary")]
        public virtual AnatomicalStructure? Tributary { get; set; }

    }
}
