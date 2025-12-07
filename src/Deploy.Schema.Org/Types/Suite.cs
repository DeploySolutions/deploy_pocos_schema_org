using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
    public partial class Suite : Accommodation
    {
        public Suite()
        {
            Type = "Suite";
        }

    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
        [JsonPropertyName("bed")]
        public virtual object? Bed { get; set; }

    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
        [JsonPropertyName("numberOfRooms")]
        public virtual object? NumberOfRooms { get; set; }

    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// 
    /// </summary>
        [JsonPropertyName("occupancy")]
        public virtual QuantitativeValue? Occupancy { get; set; }

    }
}
