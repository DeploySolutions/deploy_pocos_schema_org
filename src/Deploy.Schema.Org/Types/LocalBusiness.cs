using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
    public partial class LocalBusiness : Organization
    {
        public LocalBusiness()
        {
            Type = "LocalBusiness";
        }

    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
        [JsonPropertyName("branchOf")]
        public virtual Organization? BranchOf { get; set; }

    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
        [JsonPropertyName("currenciesAccepted")]
        public virtual string? CurrenciesAccepted { get; set; }

    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
        [JsonPropertyName("openingHours")]
        public virtual string? OpeningHours { get; set; }

    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
        [JsonPropertyName("paymentAccepted")]
        public virtual string? PaymentAccepted { get; set; }

    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
        [JsonPropertyName("priceRange")]
        public virtual string? PriceRange { get; set; }

    }
}
