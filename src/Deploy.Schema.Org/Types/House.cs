using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// </summary>
    public partial class House : Accommodation
    {
        public House()
        {
            Type = "House";
        }

    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// </summary>
        [JsonPropertyName("numberOfRooms")]
        public virtual object? NumberOfRooms { get; set; }

    }
}
