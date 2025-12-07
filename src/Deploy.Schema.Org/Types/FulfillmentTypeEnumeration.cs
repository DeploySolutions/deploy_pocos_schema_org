using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A type of product fulfillment.
    /// </summary>
    public partial class FulfillmentTypeEnumeration : Enumeration
    {
        public FulfillmentTypeEnumeration()
        {
            Type = "FulfillmentTypeEnumeration";
        }

    }
}
