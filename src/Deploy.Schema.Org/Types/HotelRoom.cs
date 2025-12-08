using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A hotel room is a single room in a hotel.
    ///
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
    public partial class HotelRoom : Room
    {
        public HotelRoom()
        {
            Type = "HotelRoom";
        }

    /// <summary>
    /// A hotel room is a single room in a hotel.
    ///
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
        [JsonPropertyName("bed")]
        public virtual object? Bed { get; set; }

    /// <summary>
    /// A hotel room is a single room in a hotel.
    ///
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
        [JsonPropertyName("occupancy")]
        public virtual QuantitativeValue? Occupancy { get; set; }

    }
}
