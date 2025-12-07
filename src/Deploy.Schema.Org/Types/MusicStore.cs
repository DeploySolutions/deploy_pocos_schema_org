using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A music store.
    /// </summary>
    public partial class MusicStore : Store
    {
        public MusicStore()
        {
            Type = "MusicStore";
        }

    }
}
