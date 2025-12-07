using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// </summary>
    public partial class MusicAlbumReleaseType : Enumeration
    {
        public MusicAlbumReleaseType()
        {
            Type = "MusicAlbumReleaseType";
        }

    }
}
