using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A taxi stand.
    /// </summary>
    public partial class TaxiStand : CivicStructure
    {
        public TaxiStand()
        {
            Type = "TaxiStand";
        }

    }
}
