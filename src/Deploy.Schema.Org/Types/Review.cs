using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    public partial class Review : CreativeWork
    {
        public Review()
        {
            Type = "Review";
        }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("associatedClaimReview")]
        public virtual Review? AssociatedClaimReview { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("associatedMediaReview")]
        public virtual Review? AssociatedMediaReview { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("associatedReview")]
        public virtual Review? AssociatedReview { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("itemReviewed")]
        public virtual Thing? ItemReviewed { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("negativeNotes")]
        public virtual object? NegativeNotes { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("positiveNotes")]
        public virtual object? PositiveNotes { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("reviewAspect")]
        public virtual string? ReviewAspect { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("reviewBody")]
        public virtual string? ReviewBody { get; set; }

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
        [JsonPropertyName("reviewRating")]
        public virtual Rating? ReviewRating { get; set; }

    }
}
