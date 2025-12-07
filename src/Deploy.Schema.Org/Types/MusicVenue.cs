using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A music venue.
    /// </summary>
    public partial class MusicVenue : CivicStructure
    {
        public MusicVenue()
        {
            Type = "MusicVenue";
        }

    }
}
