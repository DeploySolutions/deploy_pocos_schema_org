using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A toy store.
    /// </summary>
    public partial class ToyStore : Store
    {
        public ToyStore()
        {
            Type = "ToyStore";
        }

    }
}
