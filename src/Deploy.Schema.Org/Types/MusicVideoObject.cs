using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A music video file.
    /// </summary>
    public partial class MusicVideoObject : MediaObject
    {
        public MusicVideoObject()
        {
            Type = "MusicVideoObject";
        }

    }
}
