using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
    public partial class ItemList : Intangible
    {
        public ItemList()
        {
            Type = "ItemList";
        }

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
        [JsonPropertyName("aggregateElement")]
        public virtual Thing? AggregateElement { get; set; }

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
        [JsonPropertyName("itemListElement")]
        public virtual object? ItemListElement { get; set; }

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
        [JsonPropertyName("itemListOrder")]
        public virtual object? ItemListOrder { get; set; }

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
        [JsonPropertyName("numberOfItems")]
        public virtual Integer? NumberOfItems { get; set; }

    }
}
