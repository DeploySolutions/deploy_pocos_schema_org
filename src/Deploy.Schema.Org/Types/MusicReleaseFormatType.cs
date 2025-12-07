using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Format of this release (the type of recording media used, i.e. compact disc, digital media, LP, etc.).
    /// </summary>
    public partial class MusicReleaseFormatType : Enumeration
    {
        public MusicReleaseFormatType()
        {
            Type = "MusicReleaseFormatType";
        }

    }
}
