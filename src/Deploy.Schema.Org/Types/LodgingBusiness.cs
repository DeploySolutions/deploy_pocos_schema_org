using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
    public partial class LodgingBusiness : LocalBusiness
    {
        public LodgingBusiness()
        {
            Type = "LodgingBusiness";
        }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("amenityFeature")]
        public virtual LocationFeatureSpecification? AmenityFeature { get; set; }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("audience")]
        public virtual Audience? Audience { get; set; }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("availableLanguage")]
        public virtual object? AvailableLanguage { get; set; }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("checkinTime")]
        public virtual object? CheckinTime { get; set; }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("checkoutTime")]
        public virtual object? CheckoutTime { get; set; }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("numberOfRooms")]
        public virtual object? NumberOfRooms { get; set; }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("petsAllowed")]
        public virtual object? PetsAllowed { get; set; }

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// </summary>
        [JsonPropertyName("starRating")]
        public virtual Rating? StarRating { get; set; }

    }
}
