using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    public partial class ListItem : Intangible
    {
        public ListItem()
        {
            Type = "ListItem";
        }

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
        [JsonPropertyName("item")]
        public virtual Thing? Item { get; set; }

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
        [JsonPropertyName("nextItem")]
        public virtual ListItem? NextItem { get; set; }

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
        [JsonPropertyName("position")]
        public virtual object? Position { get; set; }

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
        [JsonPropertyName("previousItem")]
        public virtual ListItem? PreviousItem { get; set; }

    }
}
