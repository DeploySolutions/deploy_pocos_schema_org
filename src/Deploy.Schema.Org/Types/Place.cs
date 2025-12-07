using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    public partial class Place : Thing
    {
        public Place()
        {
            Type = "Place";
        }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("additionalProperty")]
        public virtual PropertyValue? AdditionalProperty { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("address")]
        public virtual object? Address { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("aggregateRating")]
        public virtual AggregateRating? AggregateRating { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("amenityFeature")]
        public virtual LocationFeatureSpecification? AmenityFeature { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("branchCode")]
        public virtual string? BranchCode { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("containedIn")]
        public virtual Place? ContainedIn { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("containedInPlace")]
        public virtual Place? ContainedInPlace { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("containsPlace")]
        public virtual Place? ContainsPlace { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("event")]
        public virtual Event? Event { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("events")]
        public virtual Event? Events { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("faxNumber")]
        public virtual string? FaxNumber { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geo")]
        public virtual object? Geo { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoContains")]
        public virtual object? GeoContains { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoCoveredBy")]
        public virtual object? GeoCoveredBy { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoCovers")]
        public virtual object? GeoCovers { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoCrosses")]
        public virtual object? GeoCrosses { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoDisjoint")]
        public virtual object? GeoDisjoint { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoEquals")]
        public virtual object? GeoEquals { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoIntersects")]
        public virtual object? GeoIntersects { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoOverlaps")]
        public virtual object? GeoOverlaps { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoTouches")]
        public virtual object? GeoTouches { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("geoWithin")]
        public virtual object? GeoWithin { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("globalLocationNumber")]
        public virtual string? GlobalLocationNumber { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("hasCertification")]
        public virtual Certification? HasCertification { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("hasDriveThroughService")]
        public virtual bool? HasDriveThroughService { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("hasGS1DigitalLink")]
        public virtual string? HasGS1DigitalLink { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("hasMap")]
        public virtual object? HasMap { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("isAccessibleForFree")]
        public virtual bool? IsAccessibleForFree { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("isicV4")]
        public virtual string? IsicV4 { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("keywords")]
        public virtual object? Keywords { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("latitude")]
        public virtual object? Latitude { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("logo")]
        public virtual object? Logo { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("longitude")]
        public virtual object? Longitude { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("map")]
        public virtual string? Map { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("maps")]
        public virtual string? Maps { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("maximumAttendeeCapacity")]
        public virtual Integer? MaximumAttendeeCapacity { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("openingHoursSpecification")]
        public virtual OpeningHoursSpecification? OpeningHoursSpecification { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("photo")]
        public virtual object? Photo { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("photos")]
        public virtual object? Photos { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("publicAccess")]
        public virtual bool? PublicAccess { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("review")]
        public virtual Review? Review { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("reviews")]
        public virtual Review? Reviews { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("slogan")]
        public virtual string? Slogan { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("smokingAllowed")]
        public virtual bool? SmokingAllowed { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("specialOpeningHoursSpecification")]
        public virtual OpeningHoursSpecification? SpecialOpeningHoursSpecification { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("telephone")]
        public virtual string? Telephone { get; set; }

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
        [JsonPropertyName("tourBookingPage")]
        public virtual string? TourBookingPage { get; set; }

    }
}
