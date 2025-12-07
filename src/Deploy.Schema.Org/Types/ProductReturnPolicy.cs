using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A ProductReturnPolicy provides information about product return policies associated with an [[Organization]] or [[Product]].
    /// </summary>
    public partial class ProductReturnPolicy : Intangible
    {
        public ProductReturnPolicy()
        {
            Type = "ProductReturnPolicy";
        }

    /// <summary>
    /// A ProductReturnPolicy provides information about product return policies associated with an [[Organization]] or [[Product]].
    /// </summary>
        [JsonPropertyName("productReturnDays")]
        public virtual Integer? ProductReturnDays { get; set; }

    /// <summary>
    /// A ProductReturnPolicy provides information about product return policies associated with an [[Organization]] or [[Product]].
    /// </summary>
        [JsonPropertyName("productReturnLink")]
        public virtual string? ProductReturnLink { get; set; }

    }
}
