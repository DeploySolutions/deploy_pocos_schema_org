using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    public partial class CoverArt : VisualArtwork
    {
        public CoverArt()
        {
            Type = "CoverArt";
        }

    }
}
