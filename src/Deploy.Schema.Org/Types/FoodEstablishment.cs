using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A food-related business.
    /// </summary>
    public partial class FoodEstablishment : LocalBusiness
    {
        public FoodEstablishment()
        {
            Type = "FoodEstablishment";
        }

    /// <summary>
    /// A food-related business.
    /// </summary>
        [JsonPropertyName("acceptsReservations")]
        public virtual object? AcceptsReservations { get; set; }

    /// <summary>
    /// A food-related business.
    /// </summary>
        [JsonPropertyName("hasMenu")]
        public virtual object? HasMenu { get; set; }

    /// <summary>
    /// A food-related business.
    /// </summary>
        [JsonPropertyName("menu")]
        public virtual object? Menu { get; set; }

    /// <summary>
    /// A food-related business.
    /// </summary>
        [JsonPropertyName("servesCuisine")]
        public virtual string? ServesCuisine { get; set; }

    /// <summary>
    /// A food-related business.
    /// </summary>
        [JsonPropertyName("starRating")]
        public virtual Rating? StarRating { get; set; }

    }
}
