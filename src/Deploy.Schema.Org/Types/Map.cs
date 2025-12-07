using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A map.
    /// </summary>
    public partial class Map : CreativeWork
    {
        public Map()
        {
            Type = "Map";
        }

    /// <summary>
    /// A map.
    /// </summary>
        [JsonPropertyName("mapType")]
        public virtual MapCategoryType? MapType { get; set; }

    }
}
