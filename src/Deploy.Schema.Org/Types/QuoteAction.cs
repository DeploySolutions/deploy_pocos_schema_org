using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// </summary>
    public partial class QuoteAction : TradeAction
    {
        public QuoteAction()
        {
            Type = "QuoteAction";
        }

    }
}
