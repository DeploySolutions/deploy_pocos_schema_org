using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A city or town.
    /// </summary>
    public partial class City : AdministrativeArea
    {
        public City()
        {
            Type = "City";
        }

    }
}
