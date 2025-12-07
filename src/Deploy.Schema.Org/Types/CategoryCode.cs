using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A Category Code.
    /// </summary>
    public partial class CategoryCode : DefinedTerm
    {
        public CategoryCode()
        {
            Type = "CategoryCode";
        }

    /// <summary>
    /// A Category Code.
    /// </summary>
        [JsonPropertyName("codeValue")]
        public virtual string? CodeValue { get; set; }

    /// <summary>
    /// A Category Code.
    /// </summary>
        [JsonPropertyName("inCodeSet")]
        public virtual object? InCodeSet { get; set; }

    }
}
