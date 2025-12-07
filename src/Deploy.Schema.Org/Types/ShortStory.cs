using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Short story or tale. A brief work of literature, usually written in narrative prose.
    /// </summary>
    public partial class ShortStory : CreativeWork
    {
        public ShortStory()
        {
            Type = "ShortStory";
        }

    }
}
