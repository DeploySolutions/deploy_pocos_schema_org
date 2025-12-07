using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A library.
    /// </summary>
    public partial class Library : LocalBusiness
    {
        public Library()
        {
            Type = "Library";
        }

    }
}
