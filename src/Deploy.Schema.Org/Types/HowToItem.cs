using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to achieve a result.
    /// </summary>
    public partial class HowToItem : ListItem
    {
        public HowToItem()
        {
            Type = "HowToItem";
        }

    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to achieve a result.
    /// </summary>
        [JsonPropertyName("requiredQuantity")]
        public virtual object? RequiredQuantity { get; set; }

    }
}
