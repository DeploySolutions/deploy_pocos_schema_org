using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    public partial class Organization : Thing
    {
        public Organization()
        {
            Type = "Organization";
        }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("acceptedPaymentMethod")]
        public virtual object? AcceptedPaymentMethod { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("actionableFeedbackPolicy")]
        public virtual object? ActionableFeedbackPolicy { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("address")]
        public virtual object? Address { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("agentInteractionStatistic")]
        public virtual InteractionCounter? AgentInteractionStatistic { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("aggregateRating")]
        public virtual AggregateRating? AggregateRating { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("alumni")]
        public virtual Person? Alumni { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("areaServed")]
        public virtual object? AreaServed { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("award")]
        public virtual string? Award { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("awards")]
        public virtual string? Awards { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("brand")]
        public virtual object? Brand { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("contactPoint")]
        public virtual ContactPoint? ContactPoint { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("contactPoints")]
        public virtual ContactPoint? ContactPoints { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("correctionsPolicy")]
        public virtual object? CorrectionsPolicy { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("department")]
        public virtual Organization? Department { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("dissolutionDate")]
        public virtual DateTime? DissolutionDate { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("diversityPolicy")]
        public virtual object? DiversityPolicy { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("diversityStaffingReport")]
        public virtual object? DiversityStaffingReport { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("duns")]
        public virtual string? Duns { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("email")]
        public virtual string? Email { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("employee")]
        public virtual Person? Employee { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("employees")]
        public virtual Person? Employees { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("ethicsPolicy")]
        public virtual object? EthicsPolicy { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("event")]
        public virtual Event? Event { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("events")]
        public virtual Event? Events { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("faxNumber")]
        public virtual string? FaxNumber { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("founder")]
        public virtual object? Founder { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("founders")]
        public virtual Person? Founders { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("foundingDate")]
        public virtual DateTime? FoundingDate { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("foundingLocation")]
        public virtual Place? FoundingLocation { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("funder")]
        public virtual object? Funder { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("funding")]
        public virtual Grant? Funding { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("globalLocationNumber")]
        public virtual string? GlobalLocationNumber { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasCertification")]
        public virtual Certification? HasCertification { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasCredential")]
        public virtual EducationalOccupationalCredential? HasCredential { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasGS1DigitalLink")]
        public virtual string? HasGS1DigitalLink { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasMemberProgram")]
        public virtual MemberProgram? HasMemberProgram { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasMerchantReturnPolicy")]
        public virtual MerchantReturnPolicy? HasMerchantReturnPolicy { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasOfferCatalog")]
        public virtual OfferCatalog? HasOfferCatalog { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasPOS")]
        public virtual Place? HasPOS { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasProductReturnPolicy")]
        public virtual ProductReturnPolicy? HasProductReturnPolicy { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("hasShippingService")]
        public virtual ShippingService? HasShippingService { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("interactionStatistic")]
        public virtual InteractionCounter? InteractionStatistic { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("isicV4")]
        public virtual string? IsicV4 { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("iso6523Code")]
        public virtual string? Iso6523Code { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("keywords")]
        public virtual object? Keywords { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("knowsAbout")]
        public virtual object? KnowsAbout { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("knowsLanguage")]
        public virtual object? KnowsLanguage { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("legalName")]
        public virtual string? LegalName { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("leiCode")]
        public virtual string? LeiCode { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("location")]
        public virtual object? Location { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("logo")]
        public virtual object? Logo { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("makesOffer")]
        public virtual Offer? MakesOffer { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("member")]
        public virtual object? Member { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("memberOf")]
        public virtual object? MemberOf { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("members")]
        public virtual object? Members { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("naics")]
        public virtual string? Naics { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("nonprofitStatus")]
        public virtual NonprofitType? NonprofitStatus { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("numberOfEmployees")]
        public virtual QuantitativeValue? NumberOfEmployees { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("ownershipFundingInfo")]
        public virtual object? OwnershipFundingInfo { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("owns")]
        public virtual object? Owns { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("parentOrganization")]
        public virtual Organization? ParentOrganization { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("publishingPrinciples")]
        public virtual object? PublishingPrinciples { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("review")]
        public virtual Review? Review { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("reviews")]
        public virtual Review? Reviews { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("seeks")]
        public virtual Demand? Seeks { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("serviceArea")]
        public virtual object? ServiceArea { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("skills")]
        public virtual object? Skills { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("slogan")]
        public virtual string? Slogan { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("sponsor")]
        public virtual object? Sponsor { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("subOrganization")]
        public virtual Organization? SubOrganization { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("taxID")]
        public virtual string? TaxID { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("telephone")]
        public virtual string? Telephone { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("unnamedSourcesPolicy")]
        public virtual object? UnnamedSourcesPolicy { get; set; }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
        [JsonPropertyName("vatID")]
        public virtual string? VatID { get; set; }

    }
}
