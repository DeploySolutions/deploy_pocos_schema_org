using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A country.
    /// </summary>
    public partial class Country : AdministrativeArea
    {
        public Country()
        {
            Type = "Country";
        }

    }
}
