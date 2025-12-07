using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A distillery.
    /// </summary>
    public partial class Distillery : FoodEstablishment
    {
        public Distillery()
        {
            Type = "Distillery";
        }

    }
}
