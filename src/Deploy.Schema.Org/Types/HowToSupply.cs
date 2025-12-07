using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    public partial class HowToSupply : HowToItem
    {
        public HowToSupply()
        {
            Type = "HowToSupply";
        }

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("estimatedCost")]
        public virtual object? EstimatedCost { get; set; }

    }
}
