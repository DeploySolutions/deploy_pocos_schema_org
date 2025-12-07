using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A movie rental store.
    /// </summary>
    public partial class MovieRentalStore : Store
    {
        public MovieRentalStore()
        {
            Type = "MovieRentalStore";
        }

    }
}
