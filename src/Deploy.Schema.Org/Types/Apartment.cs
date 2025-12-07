using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// </summary>
    public partial class Apartment : Accommodation
    {
        public Apartment()
        {
            Type = "Apartment";
        }

    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// </summary>
        [JsonPropertyName("numberOfRooms")]
        public virtual object? NumberOfRooms { get; set; }

    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// </summary>
        [JsonPropertyName("occupancy")]
        public virtual QuantitativeValue? Occupancy { get; set; }

    }
}
