using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
    public partial class CreativeWork : Thing
    {
        public CreativeWork()
        {
            Type = "CreativeWork";
        }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("about")]
        public virtual Thing? About { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("abstract")]
        public virtual string? Abstract { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accessibilityAPI")]
        public virtual string? AccessibilityAPI { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accessibilityControl")]
        public virtual string? AccessibilityControl { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accessibilityFeature")]
        public virtual string? AccessibilityFeature { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accessibilityHazard")]
        public virtual string? AccessibilityHazard { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accessibilitySummary")]
        public virtual string? AccessibilitySummary { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accessMode")]
        public virtual string? AccessMode { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accessModeSufficient")]
        public virtual ItemList? AccessModeSufficient { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("accountablePerson")]
        public virtual Person? AccountablePerson { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("acquireLicensePage")]
        public virtual object? AcquireLicensePage { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("aggregateRating")]
        public virtual AggregateRating? AggregateRating { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("alternativeHeadline")]
        public virtual string? AlternativeHeadline { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("archivedAt")]
        public virtual object? ArchivedAt { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("assesses")]
        public virtual object? Assesses { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("associatedMedia")]
        public virtual MediaObject? AssociatedMedia { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("audience")]
        public virtual Audience? Audience { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("audio")]
        public virtual object? Audio { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("author")]
        public virtual object? Author { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("award")]
        public virtual string? Award { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("awards")]
        public virtual string? Awards { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("character")]
        public virtual Person? Character { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("citation")]
        public virtual object? Citation { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("comment")]
        public virtual Comment? Comment { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("commentCount")]
        public virtual Integer? CommentCount { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("conditionsOfAccess")]
        public virtual string? ConditionsOfAccess { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("contentLocation")]
        public virtual Place? ContentLocation { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("contentRating")]
        public virtual object? ContentRating { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("contentReferenceTime")]
        public virtual DateTime? ContentReferenceTime { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("contributor")]
        public virtual object? Contributor { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("copyrightHolder")]
        public virtual object? CopyrightHolder { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("copyrightNotice")]
        public virtual string? CopyrightNotice { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("copyrightYear")]
        public virtual double? CopyrightYear { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("correction")]
        public virtual object? Correction { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("countryOfOrigin")]
        public virtual Country? CountryOfOrigin { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("creativeWorkStatus")]
        public virtual object? CreativeWorkStatus { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("creator")]
        public virtual object? Creator { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("creditText")]
        public virtual string? CreditText { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("dateCreated")]
        public virtual object? DateCreated { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("dateModified")]
        public virtual object? DateModified { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("datePublished")]
        public virtual object? DatePublished { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("digitalSourceType")]
        public virtual IPTCDigitalSourceEnumeration? DigitalSourceType { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("discussionUrl")]
        public virtual string? DiscussionUrl { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("editEIDR")]
        public virtual object? EditEIDR { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("editor")]
        public virtual Person? Editor { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("educationalAlignment")]
        public virtual AlignmentObject? EducationalAlignment { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("educationalLevel")]
        public virtual object? EducationalLevel { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("educationalUse")]
        public virtual object? EducationalUse { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("encoding")]
        public virtual MediaObject? Encoding { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("encodingFormat")]
        public virtual object? EncodingFormat { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("encodings")]
        public virtual MediaObject? Encodings { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("exampleOfWork")]
        public virtual CreativeWork? ExampleOfWork { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("expires")]
        public virtual object? Expires { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("fileFormat")]
        public virtual object? FileFormat { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("funder")]
        public virtual object? Funder { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("funding")]
        public virtual Grant? Funding { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("genre")]
        public virtual object? Genre { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("hasPart")]
        public virtual CreativeWork? HasPart { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("headline")]
        public virtual string? Headline { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("inLanguage")]
        public virtual object? InLanguage { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("interactionStatistic")]
        public virtual InteractionCounter? InteractionStatistic { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("interactivityType")]
        public virtual string? InteractivityType { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("interpretedAsClaim")]
        public virtual Claim? InterpretedAsClaim { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("isAccessibleForFree")]
        public virtual bool? IsAccessibleForFree { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("isBasedOn")]
        public virtual object? IsBasedOn { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("isBasedOnUrl")]
        public virtual object? IsBasedOnUrl { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("isFamilyFriendly")]
        public virtual bool? IsFamilyFriendly { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("isPartOf")]
        public virtual object? IsPartOf { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("keywords")]
        public virtual object? Keywords { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("learningResourceType")]
        public virtual object? LearningResourceType { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("license")]
        public virtual object? License { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("locationCreated")]
        public virtual Place? LocationCreated { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("mainEntity")]
        public virtual Thing? MainEntity { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("maintainer")]
        public virtual object? Maintainer { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("material")]
        public virtual object? Material { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("materialExtent")]
        public virtual object? MaterialExtent { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("mentions")]
        public virtual Thing? Mentions { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("offers")]
        public virtual object? Offers { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("pattern")]
        public virtual object? Pattern { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("position")]
        public virtual object? Position { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("producer")]
        public virtual object? Producer { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("provider")]
        public virtual object? Provider { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("publication")]
        public virtual PublicationEvent? Publication { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("publisher")]
        public virtual object? Publisher { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("publisherImprint")]
        public virtual Organization? PublisherImprint { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("publishingPrinciples")]
        public virtual object? PublishingPrinciples { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("recordedAt")]
        public virtual Event? RecordedAt { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("releasedEvent")]
        public virtual PublicationEvent? ReleasedEvent { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("review")]
        public virtual Review? Review { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("reviews")]
        public virtual Review? Reviews { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("schemaVersion")]
        public virtual object? SchemaVersion { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("sdDatePublished")]
        public virtual DateTime? SdDatePublished { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("sdLicense")]
        public virtual object? SdLicense { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("sdPublisher")]
        public virtual object? SdPublisher { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("size")]
        public virtual object? Size { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("sourceOrganization")]
        public virtual Organization? SourceOrganization { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("spatial")]
        public virtual Place? Spatial { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("spatialCoverage")]
        public virtual Place? SpatialCoverage { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("sponsor")]
        public virtual object? Sponsor { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("teaches")]
        public virtual object? Teaches { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("temporal")]
        public virtual object? Temporal { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("temporalCoverage")]
        public virtual object? TemporalCoverage { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("text")]
        public virtual string? Text { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("thumbnail")]
        public virtual ImageObject? Thumbnail { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public virtual string? ThumbnailUrl { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("timeRequired")]
        public virtual Duration? TimeRequired { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("translationOfWork")]
        public virtual CreativeWork? TranslationOfWork { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("translator")]
        public virtual object? Translator { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("typicalAgeRange")]
        public virtual string? TypicalAgeRange { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("usageInfo")]
        public virtual object? UsageInfo { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("version")]
        public virtual object? Version { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("video")]
        public virtual object? Video { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("wordCount")]
        public virtual Integer? WordCount { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("workExample")]
        public virtual CreativeWork? WorkExample { get; set; }

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
        [JsonPropertyName("workTranslation")]
        public virtual CreativeWork? WorkTranslation { get; set; }

    }
}
