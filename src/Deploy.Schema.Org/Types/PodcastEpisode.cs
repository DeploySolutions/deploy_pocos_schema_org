using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A single episode of a podcast series.
    /// </summary>
    public partial class PodcastEpisode : Episode
    {
        public PodcastEpisode()
        {
            Type = "PodcastEpisode";
        }

    }
}
