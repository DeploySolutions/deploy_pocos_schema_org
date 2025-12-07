using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// </summary>
    public partial class RadioClip : Clip
    {
        public RadioClip()
        {
            Type = "RadioClip";
        }

    }
}
