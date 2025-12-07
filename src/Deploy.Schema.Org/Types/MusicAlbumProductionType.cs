using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Classification of the album by its type of content: soundtrack, live album, studio album, etc.
    /// </summary>
    public partial class MusicAlbumProductionType : Enumeration
    {
        public MusicAlbumProductionType()
        {
            Type = "MusicAlbumProductionType";
        }

    }
}
