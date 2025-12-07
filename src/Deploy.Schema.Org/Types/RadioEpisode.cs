using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// </summary>
    public partial class RadioEpisode : Episode
    {
        public RadioEpisode()
        {
            Type = "RadioEpisode";
        }

    }
}
