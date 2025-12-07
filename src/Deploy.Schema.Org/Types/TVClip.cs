using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
    public partial class TVClip : Clip
    {
        public TVClip()
        {
            Type = "TVClip";
        }

    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
        [JsonPropertyName("partOfTVSeries")]
        public virtual TVSeries? PartOfTVSeries { get; set; }

    }
}
