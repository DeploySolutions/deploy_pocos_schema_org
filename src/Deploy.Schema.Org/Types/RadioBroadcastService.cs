using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A delivery service through which radio content is provided via broadcast over the air or online.
    /// </summary>
    public partial class RadioBroadcastService : BroadcastService
    {
        public RadioBroadcastService()
        {
            Type = "RadioBroadcastService";
        }

    }
}
