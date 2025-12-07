using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    public partial class Person : Thing
    {
        public Person()
        {
            Type = "Person";
        }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("additionalName")]
        public virtual string? AdditionalName { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("address")]
        public virtual object? Address { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("affiliation")]
        public virtual Organization? Affiliation { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("agentInteractionStatistic")]
        public virtual InteractionCounter? AgentInteractionStatistic { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("alumniOf")]
        public virtual object? AlumniOf { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("award")]
        public virtual string? Award { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("awards")]
        public virtual string? Awards { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("birthDate")]
        public virtual DateTime? BirthDate { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("birthPlace")]
        public virtual Place? BirthPlace { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("brand")]
        public virtual object? Brand { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("callSign")]
        public virtual string? CallSign { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("children")]
        public virtual Person? Children { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("colleague")]
        public virtual object? Colleague { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("colleagues")]
        public virtual Person? Colleagues { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("contactPoint")]
        public virtual ContactPoint? ContactPoint { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("contactPoints")]
        public virtual ContactPoint? ContactPoints { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("deathDate")]
        public virtual DateTime? DeathDate { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("deathPlace")]
        public virtual Place? DeathPlace { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("duns")]
        public virtual string? Duns { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("email")]
        public virtual string? Email { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("familyName")]
        public virtual string? FamilyName { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("faxNumber")]
        public virtual string? FaxNumber { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("follows")]
        public virtual Person? Follows { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("funder")]
        public virtual object? Funder { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("funding")]
        public virtual Grant? Funding { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("gender")]
        public virtual object? Gender { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("givenName")]
        public virtual string? GivenName { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("globalLocationNumber")]
        public virtual string? GlobalLocationNumber { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("hasCertification")]
        public virtual Certification? HasCertification { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("hasCredential")]
        public virtual EducationalOccupationalCredential? HasCredential { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("hasOccupation")]
        public virtual Occupation? HasOccupation { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("hasOfferCatalog")]
        public virtual OfferCatalog? HasOfferCatalog { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("hasPOS")]
        public virtual Place? HasPOS { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("height")]
        public virtual object? Height { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("homeLocation")]
        public virtual object? HomeLocation { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("honorificPrefix")]
        public virtual string? HonorificPrefix { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("honorificSuffix")]
        public virtual string? HonorificSuffix { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("interactionStatistic")]
        public virtual InteractionCounter? InteractionStatistic { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("isicV4")]
        public virtual string? IsicV4 { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("jobTitle")]
        public virtual object? JobTitle { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("knows")]
        public virtual Person? Knows { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("knowsAbout")]
        public virtual object? KnowsAbout { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("knowsLanguage")]
        public virtual object? KnowsLanguage { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("makesOffer")]
        public virtual Offer? MakesOffer { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("memberOf")]
        public virtual object? MemberOf { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("naics")]
        public virtual string? Naics { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("nationality")]
        public virtual Country? Nationality { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("netWorth")]
        public virtual object? NetWorth { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("owns")]
        public virtual object? Owns { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("parent")]
        public virtual Person? Parent { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("parents")]
        public virtual Person? Parents { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("performerIn")]
        public virtual Event? PerformerIn { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("publishingPrinciples")]
        public virtual object? PublishingPrinciples { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("relatedTo")]
        public virtual Person? RelatedTo { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("seeks")]
        public virtual Demand? Seeks { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("sibling")]
        public virtual Person? Sibling { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("siblings")]
        public virtual Person? Siblings { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("skills")]
        public virtual object? Skills { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("sponsor")]
        public virtual object? Sponsor { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("spouse")]
        public virtual Person? Spouse { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("taxID")]
        public virtual string? TaxID { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("telephone")]
        public virtual string? Telephone { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("vatID")]
        public virtual string? VatID { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("weight")]
        public virtual object? Weight { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("workLocation")]
        public virtual object? WorkLocation { get; set; }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
        [JsonPropertyName("worksFor")]
        public virtual Organization? WorksFor { get; set; }

    }
}
