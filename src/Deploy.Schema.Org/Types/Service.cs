using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
    public partial class Service : Intangible
    {
        public Service()
        {
            Type = "Service";
        }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("aggregateRating")]
        public virtual AggregateRating? AggregateRating { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("areaServed")]
        public virtual object? AreaServed { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("audience")]
        public virtual Audience? Audience { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("availableChannel")]
        public virtual ServiceChannel? AvailableChannel { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("award")]
        public virtual string? Award { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("brand")]
        public virtual object? Brand { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("broker")]
        public virtual object? Broker { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("category")]
        public virtual object? Category { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("hasCertification")]
        public virtual Certification? HasCertification { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("hasOfferCatalog")]
        public virtual OfferCatalog? HasOfferCatalog { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("hoursAvailable")]
        public virtual OpeningHoursSpecification? HoursAvailable { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("isRelatedTo")]
        public virtual object? IsRelatedTo { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("isSimilarTo")]
        public virtual object? IsSimilarTo { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("logo")]
        public virtual object? Logo { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("offers")]
        public virtual object? Offers { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("produces")]
        public virtual Thing? Produces { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("providerMobility")]
        public virtual string? ProviderMobility { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("review")]
        public virtual Review? Review { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("serviceArea")]
        public virtual object? ServiceArea { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("serviceAudience")]
        public virtual Audience? ServiceAudience { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("serviceOutput")]
        public virtual Thing? ServiceOutput { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("serviceType")]
        public virtual object? ServiceType { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("slogan")]
        public virtual string? Slogan { get; set; }

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
        [JsonPropertyName("termsOfService")]
        public virtual object? TermsOfService { get; set; }

    }
}
