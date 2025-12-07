using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A short segment/part of a video game.
    /// </summary>
    public partial class VideoGameClip : Clip
    {
        public VideoGameClip()
        {
            Type = "VideoGameClip";
        }

    }
}
