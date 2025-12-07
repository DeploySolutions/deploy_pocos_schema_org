using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A single season of a podcast. Many podcasts do not break down into separate seasons. In that case, PodcastSeries should be used.
    /// </summary>
    public partial class PodcastSeason : CreativeWorkSeason
    {
        public PodcastSeason()
        {
            Type = "PodcastSeason";
        }

    }
}
