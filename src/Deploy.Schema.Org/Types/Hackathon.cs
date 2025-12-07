using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A [hackathon](https://en.wikipedia.org/wiki/Hackathon) event.
    /// </summary>
    public partial class Hackathon : Event
    {
        public Hackathon()
        {
            Type = "Hackathon";
        }

    }
}
