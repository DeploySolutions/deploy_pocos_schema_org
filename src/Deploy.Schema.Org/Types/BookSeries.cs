using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// </summary>
    public partial class BookSeries : CreativeWorkSeries
    {
        public BookSeries()
        {
            Type = "BookSeries";
        }

    }
}
