using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A list of possible conditions for the item.
    /// </summary>
    public partial class OfferItemCondition : Enumeration
    {
        public OfferItemCondition()
        {
            Type = "OfferItemCondition";
        }

    }
}
