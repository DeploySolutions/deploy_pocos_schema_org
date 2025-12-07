using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// An art gallery.
    /// </summary>
    public partial class ArtGallery : EntertainmentBusiness
    {
        public ArtGallery()
        {
            Type = "ArtGallery";
        }

    }
}
