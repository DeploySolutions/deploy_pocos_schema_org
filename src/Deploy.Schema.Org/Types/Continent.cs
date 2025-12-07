using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    public partial class Continent : Landform
    {
        public Continent()
        {
            Type = "Continent";
        }

    }
}
