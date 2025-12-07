using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A short segment/part of a movie.
    /// </summary>
    public partial class MovieClip : Clip
    {
        public MovieClip()
        {
            Type = "MovieClip";
        }

    }
}
