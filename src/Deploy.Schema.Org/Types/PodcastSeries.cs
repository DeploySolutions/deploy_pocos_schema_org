using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A podcast is an episodic series of digital audio or video files which a user can download and listen to.
    /// </summary>
    public partial class PodcastSeries : CreativeWorkSeries
    {
        public PodcastSeries()
        {
            Type = "PodcastSeries";
        }

    /// <summary>
    /// A podcast is an episodic series of digital audio or video files which a user can download and listen to.
    /// </summary>
        [JsonPropertyName("actor")]
        public virtual object? Actor { get; set; }

    /// <summary>
    /// A podcast is an episodic series of digital audio or video files which a user can download and listen to.
    /// </summary>
        [JsonPropertyName("webFeed")]
        public virtual object? WebFeed { get; set; }

    }
}
