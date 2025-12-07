using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A tourist trip. A created itinerary of visits to one or more places of interest ([[TouristAttraction]]/[[TouristDestination]]) often linked by a similar theme, geographic area, or interest to a particular [[touristType]]. The [UNWTO](http://www2.unwto.org/) defines tourism trip as the Trip taken by visitors.
    ///   (See examples below.)
    /// </summary>
    public partial class TouristTrip : Trip
    {
        public TouristTrip()
        {
            Type = "TouristTrip";
        }

    /// <summary>
    /// A tourist trip. A created itinerary of visits to one or more places of interest ([[TouristAttraction]]/[[TouristDestination]]) often linked by a similar theme, geographic area, or interest to a particular [[touristType]]. The [UNWTO](http://www2.unwto.org/) defines tourism trip as the Trip taken by visitors.
    ///   (See examples below.)
    /// </summary>
        [JsonPropertyName("touristType")]
        public virtual object? TouristType { get; set; }

    }
}
