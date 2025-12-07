using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A set of Category Code values.
    /// </summary>
    public partial class CategoryCodeSet : DefinedTermSet
    {
        public CategoryCodeSet()
        {
            Type = "CategoryCodeSet";
        }

    /// <summary>
    /// A set of Category Code values.
    /// </summary>
        [JsonPropertyName("hasCategoryCode")]
        public virtual CategoryCode? HasCategoryCode { get; set; }

    }
}
