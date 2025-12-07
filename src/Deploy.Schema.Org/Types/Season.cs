using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// </summary>
    public partial class Season : CreativeWork
    {
        public Season()
        {
            Type = "Season";
        }

    }
}
