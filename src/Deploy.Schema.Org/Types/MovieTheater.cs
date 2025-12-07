using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A movie theater.
    /// </summary>
    public partial class MovieTheater : EntertainmentBusiness
    {
        public MovieTheater()
        {
            Type = "MovieTheater";
        }

    /// <summary>
    /// A movie theater.
    /// </summary>
        [JsonPropertyName("screenCount")]
        public virtual double? ScreenCount { get; set; }

    }
}
