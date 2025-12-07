using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    public partial class ApartmentComplex : Residence
    {
        public ApartmentComplex()
        {
            Type = "ApartmentComplex";
        }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
        [JsonPropertyName("numberOfAccommodationUnits")]
        public virtual QuantitativeValue? NumberOfAccommodationUnits { get; set; }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
        [JsonPropertyName("numberOfAvailableAccommodationUnits")]
        public virtual QuantitativeValue? NumberOfAvailableAccommodationUnits { get; set; }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
        [JsonPropertyName("numberOfBedrooms")]
        public virtual object? NumberOfBedrooms { get; set; }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
        [JsonPropertyName("petsAllowed")]
        public virtual object? PetsAllowed { get; set; }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
        [JsonPropertyName("tourBookingPage")]
        public virtual string? TourBookingPage { get; set; }

    }
}
