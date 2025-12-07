using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Video gallery page.
    /// </summary>
    public partial class VideoGallery : MediaGallery
    {
        public VideoGallery()
        {
            Type = "VideoGallery";
        }

    }
}
