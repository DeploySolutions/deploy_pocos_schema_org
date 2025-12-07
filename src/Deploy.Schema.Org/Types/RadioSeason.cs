using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    public partial class RadioSeason : CreativeWorkSeason
    {
        public RadioSeason()
        {
            Type = "RadioSeason";
        }

    }
}
