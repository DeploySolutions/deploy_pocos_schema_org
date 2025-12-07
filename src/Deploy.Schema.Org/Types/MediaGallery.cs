using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Media gallery page. A mixed-media page that can contain media such as images, videos, and other multimedia.
    /// </summary>
    public partial class MediaGallery : CollectionPage
    {
        public MediaGallery()
        {
            Type = "MediaGallery";
        }

    }
}
