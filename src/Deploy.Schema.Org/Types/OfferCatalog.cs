using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.
    /// </summary>
    public partial class OfferCatalog : ItemList
    {
        public OfferCatalog()
        {
            Type = "OfferCatalog";
        }

    }
}
