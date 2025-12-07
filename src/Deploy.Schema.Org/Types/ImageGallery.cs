using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    public partial class ImageGallery : MediaGallery
    {
        public ImageGallery()
        {
            Type = "ImageGallery";
        }

    }
}
