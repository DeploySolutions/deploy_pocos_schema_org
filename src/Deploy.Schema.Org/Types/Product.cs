using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    public partial class Product : Thing
    {
        public Product()
        {
            Type = "Product";
        }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("additionalProperty")]
        public virtual PropertyValue? AdditionalProperty { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("aggregateRating")]
        public virtual AggregateRating? AggregateRating { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("asin")]
        public virtual object? Asin { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("audience")]
        public virtual Audience? Audience { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("award")]
        public virtual string? Award { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("awards")]
        public virtual string? Awards { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("brand")]
        public virtual object? Brand { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("category")]
        public virtual object? Category { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("color")]
        public virtual string? Color { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("colorSwatch")]
        public virtual object? ColorSwatch { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("countryOfAssembly")]
        public virtual string? CountryOfAssembly { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("countryOfLastProcessing")]
        public virtual string? CountryOfLastProcessing { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("countryOfOrigin")]
        public virtual Country? CountryOfOrigin { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("depth")]
        public virtual object? Depth { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("funding")]
        public virtual Grant? Funding { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("gtin")]
        public virtual object? Gtin { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("gtin12")]
        public virtual string? Gtin12 { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("gtin13")]
        public virtual string? Gtin13 { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("gtin14")]
        public virtual string? Gtin14 { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("gtin8")]
        public virtual string? Gtin8 { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("hasAdultConsideration")]
        public virtual AdultOrientedEnumeration? HasAdultConsideration { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("hasCertification")]
        public virtual Certification? HasCertification { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("hasEnergyConsumptionDetails")]
        public virtual EnergyConsumptionDetails? HasEnergyConsumptionDetails { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("hasGS1DigitalLink")]
        public virtual string? HasGS1DigitalLink { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("hasMeasurement")]
        public virtual QuantitativeValue? HasMeasurement { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("hasMerchantReturnPolicy")]
        public virtual MerchantReturnPolicy? HasMerchantReturnPolicy { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("hasProductReturnPolicy")]
        public virtual ProductReturnPolicy? HasProductReturnPolicy { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("height")]
        public virtual object? Height { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("inProductGroupWithID")]
        public virtual string? InProductGroupWithID { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("isAccessoryOrSparePartFor")]
        public virtual Product? IsAccessoryOrSparePartFor { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("isConsumableFor")]
        public virtual Product? IsConsumableFor { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("isFamilyFriendly")]
        public virtual bool? IsFamilyFriendly { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("isRelatedTo")]
        public virtual object? IsRelatedTo { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("isSimilarTo")]
        public virtual object? IsSimilarTo { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("isVariantOf")]
        public virtual object? IsVariantOf { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("itemCondition")]
        public virtual OfferItemCondition? ItemCondition { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("keywords")]
        public virtual object? Keywords { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("logo")]
        public virtual object? Logo { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("manufacturer")]
        public virtual Organization? Manufacturer { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("material")]
        public virtual object? Material { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("mobileUrl")]
        public virtual string? MobileUrl { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("model")]
        public virtual object? Model { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("mpn")]
        public virtual string? Mpn { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("negativeNotes")]
        public virtual object? NegativeNotes { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("nsn")]
        public virtual string? Nsn { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("offers")]
        public virtual object? Offers { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("pattern")]
        public virtual object? Pattern { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("positiveNotes")]
        public virtual object? PositiveNotes { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("productID")]
        public virtual string? ProductID { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("productionDate")]
        public virtual DateTime? ProductionDate { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("purchaseDate")]
        public virtual DateTime? PurchaseDate { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("releaseDate")]
        public virtual DateTime? ReleaseDate { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("review")]
        public virtual Review? Review { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("reviews")]
        public virtual Review? Reviews { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("size")]
        public virtual object? Size { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("sku")]
        public virtual string? Sku { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("slogan")]
        public virtual string? Slogan { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("weight")]
        public virtual object? Weight { get; set; }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
        [JsonPropertyName("width")]
        public virtual object? Width { get; set; }

    }
}
