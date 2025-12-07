using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The artwork on the cover of a comic.
    /// </summary>
    public partial class ComicCoverArt : ComicStory
    {
        public ComicCoverArt()
        {
            Type = "ComicCoverArt";
        }

    }
}
