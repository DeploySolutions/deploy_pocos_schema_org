using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A book.
    /// </summary>
    public partial class Book : CreativeWork
    {
        public Book()
        {
            Type = "Book";
        }

    /// <summary>
    /// A book.
    /// </summary>
        [JsonPropertyName("abridged")]
        public virtual bool? Abridged { get; set; }

    /// <summary>
    /// A book.
    /// </summary>
        [JsonPropertyName("bookEdition")]
        public virtual string? BookEdition { get; set; }

    /// <summary>
    /// A book.
    /// </summary>
        [JsonPropertyName("bookFormat")]
        public virtual BookFormatType? BookFormat { get; set; }

    /// <summary>
    /// A book.
    /// </summary>
        [JsonPropertyName("illustrator")]
        public virtual Person? Illustrator { get; set; }

    /// <summary>
    /// A book.
    /// </summary>
        [JsonPropertyName("isbn")]
        public virtual string? Isbn { get; set; }

    /// <summary>
    /// A book.
    /// </summary>
        [JsonPropertyName("numberOfPages")]
        public virtual Integer? NumberOfPages { get; set; }

    }
}
