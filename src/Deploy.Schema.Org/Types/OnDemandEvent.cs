using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A publication event, e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// </summary>
    public partial class OnDemandEvent : PublicationEvent
    {
        public OnDemandEvent()
        {
            Type = "OnDemandEvent";
        }

    }
}
