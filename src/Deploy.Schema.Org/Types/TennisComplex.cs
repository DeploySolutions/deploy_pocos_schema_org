using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A tennis complex.
    /// </summary>
    public partial class TennisComplex : SportsActivityLocation
    {
        public TennisComplex()
        {
            Type = "TennisComplex";
        }

    }
}
