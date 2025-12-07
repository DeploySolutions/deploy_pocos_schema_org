using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A restaurant.
    /// </summary>
    public partial class Restaurant : FoodEstablishment
    {
        public Restaurant()
        {
            Type = "Restaurant";
        }

    }
}
