using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 kg' or '4 milligrams'.
    /// </summary>
    public partial class Quantity : Intangible
    {
        public Quantity()
        {
            Type = "Quantity";
        }

    }
}
