using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates different price types, for example list price, invoice price, and sale price.
    /// </summary>
    public partial class PriceTypeEnumeration : Enumeration
    {
        public PriceTypeEnumeration()
        {
            Type = "PriceTypeEnumeration";
        }

    }
}
