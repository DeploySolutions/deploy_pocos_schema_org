using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The publication format of the book.
    /// </summary>
    public partial class BookFormatType : Enumeration
    {
        public BookFormatType()
        {
            Type = "BookFormatType";
        }

    }
}
