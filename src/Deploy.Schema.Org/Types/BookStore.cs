using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bookstore.
    /// </summary>
    public partial class BookStore : Store
    {
        public BookStore()
        {
            Type = "BookStore";
        }

    }
}
