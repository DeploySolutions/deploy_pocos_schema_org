using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A winery.
    /// </summary>
    public partial class Winery : FoodEstablishment
    {
        public Winery()
        {
            Type = "Winery";
        }

    }
}
