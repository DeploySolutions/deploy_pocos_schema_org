using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// </summary>
    public partial class WatchAction : ConsumeAction
    {
        public WatchAction()
        {
            Type = "WatchAction";
        }

    }
}
