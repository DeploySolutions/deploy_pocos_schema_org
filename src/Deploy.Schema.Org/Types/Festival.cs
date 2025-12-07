using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// Event type: Festival.
    /// </summary>
    public partial class Festival : Event
    {
        public Festival()
        {
            Type = "Festival";
        }

    }
}
