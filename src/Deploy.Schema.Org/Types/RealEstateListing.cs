using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [[RealEstateListing]] is a listing that describes one or more real-estate [[Offer]]s (whose [[businessFunction]] is typically to lease out, or to sell).
    /// The [[RealEstateListing]] type itself represents the overall listing, as manifested in some [[WebPage]].
    /// </summary>
    public partial class RealEstateListing : WebPage
    {
        public RealEstateListing()
        {
            Type = "RealEstateListing";
        }

    /// <summary>
    /// A [[RealEstateListing]] is a listing that describes one or more real-estate [[Offer]]s (whose [[businessFunction]] is typically to lease out, or to sell).
    /// The [[RealEstateListing]] type itself represents the overall listing, as manifested in some [[WebPage]].
    /// </summary>
        [JsonPropertyName("datePosted")]
        public virtual object? DatePosted { get; set; }

    /// <summary>
    /// A [[RealEstateListing]] is a listing that describes one or more real-estate [[Offer]]s (whose [[businessFunction]] is typically to lease out, or to sell).
    /// The [[RealEstateListing]] type itself represents the overall listing, as manifested in some [[WebPage]].
    /// </summary>
        [JsonPropertyName("leaseLength")]
        public virtual object? LeaseLength { get; set; }

    }
}
