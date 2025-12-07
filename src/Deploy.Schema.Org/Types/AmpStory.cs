using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A creative work with a visual storytelling format intended to be viewed online, particularly on mobile devices.
    /// </summary>
    public partial class AmpStory : MediaObject
    {
        public AmpStory()
        {
            Type = "AmpStory";
        }

    }
}
