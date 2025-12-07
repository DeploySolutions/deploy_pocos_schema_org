using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A collection of items, e.g. creative works or products.
    /// </summary>
    public partial class Collection : CreativeWork
    {
        public Collection()
        {
            Type = "Collection";
        }

    /// <summary>
    /// A collection of items, e.g. creative works or products.
    /// </summary>
        [JsonPropertyName("collectionSize")]
        public virtual Integer? CollectionSize { get; set; }

    }
}
