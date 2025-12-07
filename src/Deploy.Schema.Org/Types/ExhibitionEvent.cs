using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// </summary>
    public partial class ExhibitionEvent : Event
    {
        public ExhibitionEvent()
        {
            Type = "ExhibitionEvent";
        }

    }
}
