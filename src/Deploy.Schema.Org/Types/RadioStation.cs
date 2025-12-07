using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A radio station.
    /// </summary>
    public partial class RadioStation : LocalBusiness
    {
        public RadioStation()
        {
            Type = "RadioStation";
        }

    }
}
