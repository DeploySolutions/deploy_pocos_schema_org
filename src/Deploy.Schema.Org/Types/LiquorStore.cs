using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// </summary>
    public partial class LiquorStore : Store
    {
        public LiquorStore()
        {
            Type = "LiquorStore";
        }

    }
}
