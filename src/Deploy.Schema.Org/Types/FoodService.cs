using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// </summary>
    public partial class FoodService : Service
    {
        public FoodService()
        {
            Type = "FoodService";
        }

    }
}
