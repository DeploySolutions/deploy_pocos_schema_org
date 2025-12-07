using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Brewery.
    /// </summary>
    public partial class Brewery : FoodEstablishment
    {
        public Brewery()
        {
            Type = "Brewery";
        }

    }
}
