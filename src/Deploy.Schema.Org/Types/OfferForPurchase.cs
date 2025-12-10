using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An [[OfferForPurchase]] in Schema.org represents an [[Offer]] to sell something, i.e. an [[Offer]] whose
    /// [[businessFunction]] is [sell](http://purl.org/goodrelations/v1#Sell.). See [Good Relations](https://en.wikipedia.org/wiki/GoodRelations) for
    /// background on the underlying concepts.
    /// </summary>
    public partial class OfferForPurchase : Offer
    {
        public OfferForPurchase()
        {
            Type = "OfferForPurchase";
        }

    }
}
