using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
    public partial class Chapter : CreativeWork
    {
        public Chapter()
        {
            Type = "Chapter";
        }

    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
        [JsonPropertyName("pageEnd")]
        public virtual object? PageEnd { get; set; }

    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
        [JsonPropertyName("pageStart")]
        public virtual object? PageStart { get; set; }

    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
        [JsonPropertyName("pagination")]
        public virtual string? Pagination { get; set; }

    }
}
