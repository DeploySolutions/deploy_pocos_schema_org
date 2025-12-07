using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A specific and exact (byte-for-byte) version of an [[ImageObject]]. Two byte-for-byte identical files, for the purposes of this type, considered identical. If they have different embedded metadata (e.g. XMP, EXIF) the files will differ. Different external facts about the files, e.g. creator or dateCreated that aren't represented in their actual content, do not affect this notion of identity.
    /// </summary>
    public partial class ImageObjectSnapshot : ImageObject
    {
        public ImageObjectSnapshot()
        {
            Type = "ImageObjectSnapshot";
        }

    }
}
