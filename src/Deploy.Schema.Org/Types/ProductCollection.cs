using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of products (either [[ProductGroup]]s or specific variants) that are listed together e.g. in an [[Offer]].
    /// </summary>
    public partial class ProductCollection : Collection
    {
        public ProductCollection()
        {
            Type = "ProductCollection";
        }

    /// <summary>
    /// A set of products (either [[ProductGroup]]s or specific variants) that are listed together e.g. in an [[Offer]].
    /// </summary>
        [JsonPropertyName("includesObject")]
        public virtual TypeAndQuantityNode? IncludesObject { get; set; }

    }
}
