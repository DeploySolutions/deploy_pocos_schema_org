using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Enumerates different price components that together make up the total price for an offered product.
    /// </summary>
    public partial class PriceComponentTypeEnumeration : Enumeration
    {
        public PriceComponentTypeEnumeration()
        {
            Type = "PriceComponentTypeEnumeration";
        }

    }
}
