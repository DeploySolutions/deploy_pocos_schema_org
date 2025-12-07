using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
    public partial class ProductModel : Product
    {
        public ProductModel()
        {
            Type = "ProductModel";
        }

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
        [JsonPropertyName("isVariantOf")]
        public virtual object? IsVariantOf { get; set; }

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
        [JsonPropertyName("predecessorOf")]
        public virtual ProductModel? PredecessorOf { get; set; }

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// </summary>
        [JsonPropertyName("successorOf")]
        public virtual ProductModel? SuccessorOf { get; set; }

    }
}
