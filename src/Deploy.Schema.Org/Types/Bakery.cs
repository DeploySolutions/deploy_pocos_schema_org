using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A bakery.
    /// </summary>
    public partial class Bakery : FoodEstablishment
    {
        public Bakery()
        {
            Type = "Bakery";
        }

    }
}
