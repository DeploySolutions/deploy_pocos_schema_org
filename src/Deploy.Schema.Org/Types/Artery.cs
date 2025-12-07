using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// </summary>
    public partial class Artery : Vessel
    {
        public Artery()
        {
            Type = "Artery";
        }

    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// </summary>
        [JsonPropertyName("arterialBranch")]
        public virtual AnatomicalStructure? ArterialBranch { get; set; }

    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// </summary>
        [JsonPropertyName("supplyTo")]
        public virtual AnatomicalStructure? SupplyTo { get; set; }

    }
}
